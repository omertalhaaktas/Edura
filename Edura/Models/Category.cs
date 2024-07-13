﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edura.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}