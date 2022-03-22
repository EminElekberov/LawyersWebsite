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

    public class NewsController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public NewsController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.News.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(News news)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            if (!news.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(news);
            }
            string folder = @"images\blog";
            var newImg = await news.Photo.Savepicture(env.WebRootPath, folder);
            news.Image = newImg;
            await _dbcontext.News.AddAsync(news);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/news/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            News news = await _dbcontext.News.FindAsync(id);
            if (news == null)
            {
                return Redirect("/NOtfound/index");

            }
            _dbcontext.News.Remove(news);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/News/Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            News news = await _dbcontext.News.FindAsync(id);
            if (news == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(news);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var news = _dbcontext.News.Find(id);
            if (news==null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(news);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(News news)
        {
            if (!ModelState.IsValid)
            {
                return View(news);
            }
            var newsdb = _dbcontext.News.Find(news.Id);
            if (news.Photo != null)
            {
                try
                {
                    string folder = @"images\home";
                    var newImg = await news.Photo.Savepicture(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, newsdb.Image);
                    newsdb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            newsdb.Dates = news.Dates;
            newsdb.ButtonOnetext = news.ButtonOnetext;
            newsdb.ButtonOneLink = news.ButtonOneLink;
            newsdb.ButtonTwotext = news.ButtonTwotext;
            newsdb.ButtonTwoLink = news.ButtonTwoLink;
            newsdb.Title = news.Title;
            newsdb.Description = news.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/news/Index");
        }
    }
}
