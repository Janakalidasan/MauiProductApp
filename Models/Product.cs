﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProductApp.Models
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string image { get; set; }
    }
}
