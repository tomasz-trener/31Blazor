using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Shared.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Barcode { get; set; }

        public double Price { get; set; } // domylsnie mapuje na decimal(18,2)

        public DateTime ReleaseDate { get; set; }
    }
}
