using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Primer_WebApi.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        //Navigacijske lastnosti
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}