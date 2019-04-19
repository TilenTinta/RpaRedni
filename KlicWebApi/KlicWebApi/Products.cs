using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlicWebApi
{
    class Products
    {
        public string Ime { get; internal set; }
        public string Cena { get; internal set; }

        public class Product
        {
            public int Id { get; set; }
            public string Ime { get; set; }
            public string Kategorija { get; set; }
            public decimal Cena { get; set; }
        }
    }
}
