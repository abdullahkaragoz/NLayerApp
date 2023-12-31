﻿using Microsoft.EntityFrameworkCore;
using NLayer.Core.Models;
using NLayer.Core.Repositories;
using NLayer.Repository;

namespace NLayerApp.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
            
        }

        public async Task<List<Product>> GetProductWithCategory()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();  
        }
    }
}
