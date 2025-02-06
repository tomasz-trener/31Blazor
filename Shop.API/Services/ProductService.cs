using D13P06Shop.Shared;
using Microsoft.EntityFrameworkCore;
using Shop.API.Models;
using Shop.Shared.Entity;
using Shop.Shared.Services;

namespace Shop.API.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;

        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<Product>> CreateProductAsync(Product newProduct)
        {
            var result = new ServiceResponse<Product>();

            try
            {
                await _dataContext.Products.AddAsync(newProduct);
                await _dataContext.SaveChangesAsync();

                result.Data = newProduct;
                result.Success = true;
                result.Message = "Data created successfully";
            }
            catch (Exception ex)
            {
                result.Message = $"Error while creating new product {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        public async Task<ServiceResponse<bool>> DeleteProductAsync(int id)
        {
            var result = new ServiceResponse<bool>();

            try
            {
                var product = await _dataContext.Products.FirstOrDefaultAsync(x => x.Id == id);
                if (product != null)
                {
                    _dataContext.Products.Remove(product);
                    await _dataContext.SaveChangesAsync();

                    result.Data = true;
                    result.Success = true;
                    result.Message = "Data deleted successfully";
                }
                else
                {
                    result.Success = false;
                    result.Message = $"Product with {id} not found";
                }
            }
            catch (Exception ex)
            {
                result.Message = $"Error while deleting product {ex.Message}";
                result.Success = false;
            }
            return result;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int id)
        {
            var result = new ServiceResponse<Product>();

            try
            {
                result.Data = await _dataContext.Products.FirstAsync(p => p.Id == id);
                // first rzuca wyjatek jesli nie znajdzie produktu 
                // fristordefault zwraca null jesli nie znajdzie produktu

                result.Success = true;
                result.Message = "Data retrieved successfully";
            }
            catch (Exception ex)
            {
                result.Message = $"Error while retrieving data from the database {ex.Message}";
                result.Success = false;
            }
            return result;
        }


        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var result = new ServiceResponse<List<Product>>();

            try
            {
                result.Data = await _dataContext.Products.ToListAsync();
                result.Success = true;
                result.Message = "Data retrieved successfully";
            }
            catch (Exception ex)
            {
                result.Message = $"Error retrieving data from the database {ex.Message}";
                result.Success = false;
            }

            return result;
        }

        public async Task<ServiceResponse<Product>> UpdateProductAsync(Product updatedProduct)
        {
            var result = new ServiceResponse<Product>();
            try
            {
                var product = await _dataContext.Products.FirstOrDefaultAsync(p => p.Id == updatedProduct.Id);
                if (product != null)
                {
                    product.Title = updatedProduct.Title;
                    product.Description = updatedProduct.Description;
                    product.Price = updatedProduct.Price;
                    product.ReleaseDate = updatedProduct.ReleaseDate;
                    product.Barcode = updatedProduct.Barcode;

                    await _dataContext.SaveChangesAsync();

                    result.Data = product;
                    result.Success = true;
                    result.Message = "Data updated successfully";
                }
                else
                {
                    result.Message = $"Product with id {updatedProduct.Id} not found";
                    result.Success = false;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"Error while updating product {ex.Message}";
                result.Success = false;
            }
            return result;
        }
    }
}
