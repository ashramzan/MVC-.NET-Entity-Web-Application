﻿using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace ProductsApp.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set;}

    }
}