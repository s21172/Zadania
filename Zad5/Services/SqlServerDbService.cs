using System.Data.Common;
using System.Data.SqlClient;
using System.Net;
using Zad5.DTO;
using Zad5.Models;

namespace Zad5.Services
{
    public class SqlServerDbService : IDbService
    {
        private readonly IConfiguration _configuration;

        public SqlServerDbService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration => _configuration;

        public async Task<AddProductResult> PostProduct(AddProductDTO productDto)
        {
            await using SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("DbConn"));
            await using DbTransaction transaction = await connection.BeginTransactionAsync();

            string SelectSql = "SELECT * FROM Product WHERE IdProduct = @idProduct";
            await using SqlCommand command = new SqlCommand(SelectSql, connection, (SqlTransaction)transaction);

            await connection.OpenAsync();
            command.Parameters.Clear();
            command.CommandText = SelectSql;
            command.Parameters.AddWithValue("idProduct", productDto.ProductId);

            SqlDataReader dataReader = command.ExecuteReader();

            if (!dataReader.Read())
            {
                await transaction.RollbackAsync();
                return new AddProductResult(HttpStatusCode.NotFound, "Product with ID: \"" + productDto.ProductId + "\" doesn't exist"); 

            }

            Product existingProduct = new Product()
            {
                IdProduct = int.Parse(dataReader["IdProduct"].ToString()),
                Name = dataReader["Name"].ToString(),
                Description = dataReader["Description"].ToString(),
                Price = double.Parse(dataReader["Price"].ToString()),

            };

            SelectSql = "SELECT COUNT(1) FROM Warehouse WHERE IdWarehouse = @idWarehouse";
            command.Parameters.Clear();
            command.CommandText = SelectSql;
            command.Parameters.AddWithValue("idWarehouse", productDto.WarehouseId);

            int? res = (int?)await command.ExecuteScalarAsync();
            if (res < 1)
            {
                await transaction.RollbackAsync();
                return new AddProductResult(HttpStatusCode.NotFound, "Warehouse with ID: \"" + productDto.WarehouseId + "\" doesn't exist"); 
            }

            if (productDto.Amount < 1)
            {
                await transaction.RollbackAsync();
                return new AddProductResult(HttpStatusCode.NotFound, "Order amount has to be more than 0");
            }


            SelectSql = "SELECT * FROM Order WHERE IdProduct = @idProduct AND Amount = @amount AND CreatedAt < @createdAt";
            command.Parameters.Clear();
            command.CommandText = SelectSql;
            command.Parameters.AddWithValue("idProduct", productDto.ProductId);
            command.Parameters.AddWithValue("amount", productDto.Amount);
            command.Parameters.AddWithValue("createdAt", productDto.CreatedAt);

            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                await transaction.RollbackAsync();
                return new AddProductResult(HttpStatusCode.NotFound, "Szukanene zamowienie nie istnieje");

            }

            Order existingOrder = new Order()
            {
                IdOrder = int.Parse(reader["IdOrder"].ToString()),
                IdProduct = int.Parse(reader["IdProduct"].ToString()),
                Amount = int.Parse(reader["Amount"].ToString()),
                CreatedAt = DateTime.Parse(reader["CreatedAt"].ToString())
            };

            SelectSql = "SELECT COUNT(1) FROM Product_Warehouse WHERE IdOrder = @idOrder";
            command.Parameters.Clear();
            command.CommandText = SelectSql;
            command.Parameters.AddWithValue("idOrder", existingOrder.IdOrder);
            res = (int?)await command.ExecuteScalarAsync();
            if (res > 0)
            {
                await transaction.RollbackAsync();
                return new AddProductResult(HttpStatusCode.NotFound, "Zamowienie zostalo juz przekazane do realizacji");
            }

            SelectSql = "UPDATE Order SET FulfilledAt = @fulfilledAt WHERE IdOrder = @idOrder";
            command.Parameters.Clear();
            command.CommandText = SelectSql;
            command.Parameters.AddWithValue("fulfilledAt", DateTime.Now);
            command.Parameters.AddWithValue("idOrder", existingOrder.IdOrder);
            await command.ExecuteNonQueryAsync();

            SelectSql = "INSERT INTO Product_Warehouse (IdWarehouse, IdProduct, IdOrder, Amount, Price, CreatedAt )VALUES (@idWarehouse, @idProduct, @idOrder, @amount, @price, @createdAt); SELECT SCOPE_IDENTITY()";
            
            
            command.Parameters.Clear();
            command.CommandText = SelectSql;
           // return new AddProductResult(HttpStatusCode.BadRequest, "");

            command.Parameters.AddWithValue("idWarehouse", productDto.WarehouseId);
            command.Parameters.AddWithValue("idProduct", productDto.ProductId);
            command.Parameters.AddWithValue("idOrder", existingOrder.IdOrder);
            command.Parameters.AddWithValue("amount", productDto.Amount);
            command.Parameters.AddWithValue("price", productDto.Amount * existingProduct.Price);
            command.Parameters.AddWithValue("createdAt", productDto.CreatedAt);

            int idProductWarehouse = Convert.ToInt32(command.ExecuteScalarAsync());
            await transaction.CommitAsync();

            return new AddProductResult(HttpStatusCode.OK, "Klucz: " + idProductWarehouse );
        }
    }
}
