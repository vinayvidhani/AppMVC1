using AppMVC1.Models;

namespace AppMVC1.Services
{
    public interface IProductReporsitory
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
