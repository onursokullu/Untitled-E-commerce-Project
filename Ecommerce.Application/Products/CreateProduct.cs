﻿using Ecommerce.Database;
using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Products
{
    public class CreateProducts
    {
        private ApplicationDbContext _context;
        public CreateProducts(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Do(int id, string Name, string Description)
        {
            _context.Products.Add(new Product { Id = id, Name = Name, Description = Description });
        }
    }
}
