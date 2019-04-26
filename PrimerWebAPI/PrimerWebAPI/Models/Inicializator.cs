using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PrimerWebAPI.Models
{
    public class Inicializator:DropCreateDatabaseIfModelChanges<TrgovinaContext>
    {
        protected override void Seed(TrgovinaContext context)
        {
            var p = new List<Product>()
            {
                new Product(){Name="Juha",Price=1.36M,ActualCost=0.99M },
                new Product(){Name="Kladivo",Price=16.99M,ActualCost=10M },
                new Product(){Name="Žoga",Price=6.99M,ActualCost=2.05M }
            };
            foreach (Product x in p)
                context.Products.Add(x);
            context.SaveChanges();
        }
    }
}