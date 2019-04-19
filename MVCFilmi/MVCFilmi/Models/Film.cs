using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFilmi.Models
{
    public class Film
    {
        public int ID { get; set; }

        public string Naslov { get; set; }

        public DateTime Izdano { get; set; }

        public String Tip { get; set; }

        public decimal Cena { get; set; }
    }
}