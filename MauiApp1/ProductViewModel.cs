using CommunityToolkit.Mvvm.ComponentModel;
using Shop.Shared.Entity;
using Shop.Shared.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    //CommunityToolkit.Mvvm

    public partial class ProductViewModel : ObservableObject
    {
        private readonly IProductService _productService;

        [ObservableProperty]
        private ObservableCollection<Product> _products;

        [ObservableProperty]
        private Product _selectedProduct;


        public ProductViewModel(IProductService productService)
        {
            _productService = productService;
            
            GetProductsAsync();
            //_selectedProduct = Products.FirstOrDefault();
        }

        public async Task GetProductsAsync()
        {
            var result = await _productService.GetProductsAsync();
            if (result.Success)
            {
                Products = new ObservableCollection<Product>(result.Data);
            }
        }
    }
}
