using LawyerbackEnd.Extension;
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

    public class BlogController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public BlogController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.BlogDetails.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BlogDetails blog)
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
            string folder = @"images\blog";
            var newImg = await blog.Photo.Savepicture(env.WebRootPath, folder);
            blog.Image = newImg;
            await _dbcontext.BlogDetails.AddAsync(blog);
            await _dbcontext.SaveChangesAsync();
            return Redirect("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            BlogDetails blog = await _dbcontext.BlogDetails.FindAsync(id);
            if (blog == null)
            {
                return Redirect("/NOtfound/index");

            }
            _dbcontext.BlogDetails.Remove(blog);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "blog silindi";
            return Redirect("/Admin/Blog/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            BlogDetails blog = _dbcontext.BlogDetails.Find(id);
            if (blog == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(blog);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            BlogDetails blog = _dbcontext.BlogDetails.Find(id);
            if (blog == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(blog);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BlogDetails blog)
        {
            if (!ModelState.IsValid)
            {
                return View(blog);
            }
            var blogDb = _dbcontext.BlogDetails.Find(blog.Id);
            if (blog.Photo != null)
            {
                try
                {
                    string folder = @"images\blog";
                    var newImg = await blog.Photo.Savepicture(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, blogDb.Image);
                    blogDb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            blogDb.Name = blog.Name;
            blogDb.Dates = blog.Dates;
            blogDb.Buttontext1 = blog.Buttontext1;
            blogDb.ButtonLink1 = blog.ButtonLink1;
            blogDb.Buttontext2 = blog.Buttontext2;
            blogDb.ButtonLink2 = blog.ButtonLink2;
            blogDb.Header = blog.Header;
            blogDb.headerDesc = blog.headerDesc;
            blogDb.Title = blog.Title;
            blogDb.titleDesc = blog.titleDesc;
            blogDb.Aphorizm = blog.Aphorizm;
            blogDb.AphirzmWriter = blog.AphirzmWriter;
            blogDb.Description = blog.Description;
            blogDb.Comment = blog.Comment;
            blogDb.AboutDesc = blog.AboutDesc;
            blogDb.RecentTitle = blog.RecentTitle;
            blogDb.RecentDesc = blog.RecentDesc;
            blogDb.CateagoriesTitle = blog.CateagoriesTitle;
            blogDb.CategoriesDesc = blog.CategoriesDesc;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Blog/Index");
        }
    }
}
