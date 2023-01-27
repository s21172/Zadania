using Zad5.DTO;

namespace Zad5.Services
{
    public interface IDbService
    {
      public Task<AddProductResult> PostProduct(AddProductDTO addProductDto);
    }
}
