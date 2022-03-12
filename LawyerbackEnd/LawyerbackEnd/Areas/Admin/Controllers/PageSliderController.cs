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
    public class PageSliderController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public PageSliderController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.PageSliders.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PageSlider pageSlider)
        {
            if (!ModelState.IsValid && pageSlider.Photo == null)
            {
                ModelState.AddModelError("photo", "Sekil daxil edin");
                return View();
            }
            if (!pageSlider.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(pageSlider);
            }
            string folder = @"images\top-bkgs";
            var newImg = await pageSlider.Photo.Savepicture(env.WebRootPath, folder);
            pageSlider.Image = newImg;
            await _dbcontext.PageSliders.AddAsync(pageSlider);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PageSlider/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            PageSlider pageSlider = await _dbcontext.PageSliders.FindAsync(id);
            if (pageSlider == null)
            {
                return NotFound();
            }
            _dbcontext.PageSliders.Remove(pageSlider);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/PageSlider/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            PageSlider pageSlider =  _dbcontext.PageSliders.Find(id);
            if (pageSlider == null)
            {
                return NotFound();
            }
            return View(pageSlider);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            PageSlider pageSlider = _dbcontext.PageSliders.Find(id);
            if (pageSlider == null)
            {
                return NotFound();
            }
            return View(pageSlider);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PageSlider pageSlider)
        {
            if (!ModelState.IsValid)
            {
                return View(pageSlider);
            }
            var sliderdb = _dbcontext.PageSliders.Find(pageSlider.Id);
            if (pageSlider.Photo != null)
            {
                try
                {
                    string folder = @"images\top-bkgs";
                    var newImg = await pageSlider.Photo.Savepicture(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, sliderdb.Image);
                    sliderdb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            sliderdb.Name = pageSlider.Name;
            sliderdb.Description = pageSlider.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PageSlider/Index");
        }
    }
}
