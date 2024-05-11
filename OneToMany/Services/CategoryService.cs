using System;
using Microsoft.EntityFrameworkCore;
using OneToMany.Data;
using OneToMany.Models;
using OneToMany.Services.Interface;

namespace OneToMany.Services
{
	public class CategoryService : ICategoryService
	{
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
		

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.Where(m => !m.SoftDeleted).ToListAsync();
        }
    }
}

