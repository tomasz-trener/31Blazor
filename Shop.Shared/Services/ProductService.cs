using D13P06Shop.Shared;
using Shop.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ServiceResponse<Product>> CreateProductAsync(Product newProduct)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(_appSettings.ProductEndpoint.CreateProduct, newProduct);
                var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Product>>();
                return result;
            }
            catch (Exception)
            {
                return new ServiceResponse<Product>() { Success = false, Message = "test" };
            }
        }

        public Task<ServiceResponse<bool>> DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Product>> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct)
        {
            throw new NotImplementedException();
        }
    }
}
