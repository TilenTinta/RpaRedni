using PrimerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PrimerWebAPI.Controllers
{
    public class Products : ApiController
    {
        Products[] products = new Products[]
        {
            new Product{ Id=1,Ime="Juha",Kategorija="Jestvine",Cena=1 },
            new Product{ Id=1,Ime="Žoga",Kategorija="Igrače",Cena=1 },
            new Product{ Id=1,Ime="Kladivo",Kategorija="Orodje",Cena=1 },

        };


        public IEnumerable<Products> GetProducts()
        {
            return Produkti;
        }
        public Products GetProducts(int id)
        {
            var product = Controllers.Products.Where((object a) => a.Id == id).FirstOrDefault();
            return product;
        }
           
    }
}
