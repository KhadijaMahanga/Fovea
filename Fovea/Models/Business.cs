﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fovea.Models
{
    public class Business
    {
        public string IdBusiness { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set;}
        public string IdSeller { get; set; }
    }
}