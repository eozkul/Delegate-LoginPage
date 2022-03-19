using BilgeAdam.Data.Entities;

namespace BilgeAdam.Data.Abstractions
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
    }
}