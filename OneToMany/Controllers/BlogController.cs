using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToMany.Data;
using OneToMany.Models;

namespace OneToMany.Controllers
{
    public class BlogController : Controller
    {

        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.Blogs.Where(m => !m.SoftDeleted).Skip(1).Take(1).ToListAsync());
        }
    }
}

