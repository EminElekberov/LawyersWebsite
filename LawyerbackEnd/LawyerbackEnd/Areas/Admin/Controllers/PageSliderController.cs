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
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Error", "Error");
                return View();
            }
            await _dbcontext.PageSliders.AddAsync(pageSlider);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PageSlider/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            PageSlider pageSlider = await _dbcontext.PageSliders.FindAsync(id);
            if (pageSlider == null)
            {
                return Redirect("/NOtfound/index");

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
            PageSlider pageSlider = _dbcontext.PageSliders.Find(id);
            if (pageSlider == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(pageSlider);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            PageSlider pageSlider = _dbcontext.PageSliders.Find(id);
            if (pageSlider == null)
            {
                return Redirect("/NOtfound/index");

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
            sliderdb.Name = pageSlider.Name;
            sliderdb.Description = pageSlider.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PageSlider/Index");
        }
    }
}
