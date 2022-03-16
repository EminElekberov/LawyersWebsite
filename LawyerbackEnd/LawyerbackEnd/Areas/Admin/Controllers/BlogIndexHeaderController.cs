using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class BlogIndexHeaderController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public BlogIndexHeaderController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.BlogIndexAbouts.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BlogIndexAbout blog)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Error", "Error");
                return View();
            }
            await _dbcontext.BlogIndexAbouts.AddAsync(blog);
            await _dbcontext.SaveChangesAsync();
            return Redirect("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BlogIndexAbout blog = await _dbcontext.BlogIndexAbouts.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            _dbcontext.BlogIndexAbouts.Remove(blog);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "blog silindi";
            return Redirect("/Admin/BlogIndexAbout/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            BlogIndexAbout blog = _dbcontext.BlogIndexAbouts.Find(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BlogIndexAbout blog = _dbcontext.BlogIndexAbouts.Find(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BlogIndexAbout blog)
        {
            if (!ModelState.IsValid)
            {
                return View(blog);
            }
            var blogDb = _dbcontext.BlogIndexAbouts.Find(blog.Id);
           
            blogDb.AboutHeadder = blog.AboutHeadder;
            blogDb.ABoutDescription = blog.ABoutDescription;
            blogDb.RecetHeader = blog.RecetHeader;
            blogDb.RecentDesc = blog.RecentDesc;
            blogDb.CategoryHEader = blog.CategoryHEader;
            blogDb.catgoryDesc = blog.catgoryDesc;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/BlogIndexHeader/Index");
        }
    }
}
