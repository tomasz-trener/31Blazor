using D13P06Shop.Shared;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Shop.Shared.Configuration;
using Shop.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Shared.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        //Microsoft.Extensions.Options
        public ProductService(HttpClient httpClient, IOptions<AppSettings> appSettings)
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

        public async Task<ServiceResponse<bool>> DeleteProductAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
            return result;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Product>>();
            return result;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync(_appSettings.ProductEndpoint.GetProducts);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<Product>>>(json);
            return result;
        }

        public async Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct)
        {
            var response = await _httpClient.PutAsJsonAsync(_appSettings.ProductEndpoint.UpdateProduct, updatedProduct);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Product>>();
            return result;
        }
    }
}
