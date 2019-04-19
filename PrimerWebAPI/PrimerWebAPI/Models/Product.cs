﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimerWebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Kategorija { get; set; }
        public decimal Cena { get; set; }
    }
}