using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Zad4.Models;

namespace Zad4.Services
{
    public class SqlServerDatabaseService : IDbService
    {
        private readonly IConfiguration _config;

        public SqlServerDatabaseService(IConfiguration config)
        {
            _config = config;
        }


        public void DeleteAnimal(int animalId)
        {
            using (SqlConnection conn = new(_config.GetConnectionString("DbConn")))
            {
                if (GetAnimalById(animalId) != null)
                {
                    SqlCommand sqlcommand = new();

                    sqlcommand.Connection = conn;
                    sqlcommand.CommandText = "DELETE FROM Animal WHERE IdAnimal = @idAnimal";
                    sqlcommand.Parameters.AddWithValue("@idAnimal", animalId);

                    conn.Open();
                    sqlcommand.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    throw new KeyNotFoundException($"Animal with ID={animalId} does not exists");
                }
            }
        }

        public IEnumerable<Animal> GetAnimals(string orderBy)
        {
            var animals = new List<Animal>();
            using (SqlConnection conn = new(_config.GetConnectionString("DbConn")))
            {
                string sqlBase = "SELECT* FROM Animal ORDER BY";
                
                SqlCommand sqlcommand = new();

                sqlcommand.Connection = conn;
                sqlcommand.CommandText = $"{sqlBase} {orderBy} ASC";


                conn.Open();

                SqlDataReader dataReader = sqlcommand.ExecuteReader();
                while (dataReader.Read())
                {
                    animals.Add(new Animal
                    {
                        IdAnimal = int.Parse(dataReader["IdAnimal"].ToString()),
                        Name = dataReader["Name"].ToString(),
                        Description = dataReader["Description"].ToString(),
                        Area = dataReader["Area"].ToString(),
                        Category = dataReader["Category"].ToString()
                    });

                }
                conn.Close();
                return animals;
                
    
            }
        }

        public void PostAnimal(Animal animal)
        {
            using (SqlConnection conn = new(_config.GetConnectionString("DbConn")))
            {
                SqlCommand sqlcommand = new();
                sqlcommand.Connection = conn;

                sqlcommand.CommandText = "INSERT INTO Animal (Name, Description, Category, Area) VALUES (@name, @description ,@category ,@area) ";
                sqlcommand.Parameters.AddWithValue("@name", animal.Name);
                sqlcommand.Parameters.AddWithValue("@description", animal.Description);
                sqlcommand.Parameters.AddWithValue("@category", animal.Category);
                sqlcommand.Parameters.AddWithValue("@area", animal.Area);

                conn.Open();
                sqlcommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void PutAnimal(int animalId, Animal animal)
        {
            using (SqlConnection conn = new(_config.GetConnectionString("DbConn")))
            {
                SqlCommand sqlcommand = new();
                sqlcommand.Connection = conn;

                sqlcommand.CommandText = "UPDATE Animal SET Name = @name, Description = @description, Category = @category, Area = @area WHERE idAnimal = @idAnimal ";
                sqlcommand.Parameters.AddWithValue("@name", animal.Name);
                sqlcommand.Parameters.AddWithValue("@description", animal.Description);
                sqlcommand.Parameters.AddWithValue("@category", animal.Category);
                sqlcommand.Parameters.AddWithValue("@area", animal.Area);
                sqlcommand.Parameters.AddWithValue("@idAnimal", animalId);

                conn.Open();
                sqlcommand.ExecuteNonQuery();
                conn.Close();
            }
        }

        public Animal GetAnimalById(int animalId)
        {
            Animal animal = null;
            using (SqlConnection conn = new(_config.GetConnectionString("DbConn")))
            {
                string sqlBase = "SELECT * FROM Animal WHERE IdAnimal =";

                SqlCommand sqlcommand = new();

                sqlcommand.Connection = conn;
                sqlcommand.CommandText = $"{sqlBase} {animalId}";


                conn.Open();

                SqlDataReader dataReader = sqlcommand.ExecuteReader();
                while (dataReader.Read())
                {
                    animal= (new Animal
                    {
                        IdAnimal = int.Parse(dataReader["IdAnimal"].ToString()),
                        Name = dataReader["Name"].ToString(),
                        Description = dataReader["Description"].ToString(),
                        Area = dataReader["Area"].ToString(),
                        Category = dataReader["Category"].ToString()
                    });

                }
                dataReader.Close();
                sqlcommand.ExecuteNonQuery();
                conn.Close();
                return animal;
                
            }
        }
    }
}
