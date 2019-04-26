using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimerWebAPI.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductID { get; set; }
        //Navigacijske lastnosti
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}