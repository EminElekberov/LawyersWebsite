using LawyerbackEnd.Extension;
using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BlogHeaderController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public BlogHeaderController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.BlogHeaders.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BlogHeader blog)
        {
            if (!ModelState.IsValid && blog.Photo == null)
            {
                ModelState.AddModelError("photo", "Sekil daxil edin");
                return View();
            }
            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(blog);
            }
            string folder = @"images\blogHeader";
            var newImg = await blog.Photo.Savepicture(env.WebRootPath, folder);
            blog.Image = newImg;
            await _dbcontext.BlogHeaders.AddAsync(blog);
            await _dbcontext.SaveChangesAsync();
            return Redirect("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BlogHeader blog = await _dbcontext.BlogHeaders.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            _dbcontext.BlogHeaders.Remove(blog);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "BlogHeader silindi";
            return Redirect("/Admin/BlogHeader/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            BlogHeader blog = _dbcontext.BlogHeaders.Find(id);
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
            BlogHeader blogs = _dbcontext.BlogHeaders.Find(id);
            if (blogs == null)
            {
                return NotFound();
            }
            return View(blogs);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BlogHeader blogg)
        {
            if (!ModelState.IsValid)
            {
                return View(blogg);
            }
            var blogDb = _dbcontext.BlogHeaders.Find(blogg.Id);
            if (blogg.Photo != null)
            {
                try
                {
                    string folder = @"images\blogHeader";
                    var newImg = await blogg.Photo.Savepicture(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, blogDb.Image);
                    blogDb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            blogDb.header = blogg.header;
            blogDb.Description = blogg.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/BlogHeader/Index");
        }
    }
}
