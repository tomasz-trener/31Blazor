using Bogus;
using Shop.Shared.Entity;

namespace Shop.DataSeeder
{
    //bogus
    public class ProductDataSeeder
    {
        public static List<Product> GenerateProductData()
        {
            var productFaker = new Faker<Product>()
                .UseSeed(123456) // seed - ziarno dzieku temu za kazdtm razem bedziem dostawac te same dane  
                .RuleFor(p => p.Id, f => f.IndexFaker + 1) // chcemy zeby indeksy zaczynaly sie od 1 
                .RuleFor(p => p.Title, f => f.Commerce.ProductName())
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription())
                .RuleFor(p => p.Barcode, f => f.Commerce.Ean13().Substring(12))
                .RuleFor(p => p.Price, f => f.Random.Double(1, 1000))
                .RuleFor(p => p.ReleaseDate, f => new DateTime(2010, 1, 1));
            var products = productFaker.Generate(50);
            return products;
        }
    }
}
