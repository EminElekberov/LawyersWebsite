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

    public class PracticeSliderController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public PracticeSliderController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.PracticeSliders.ToList());
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            PracticeSlider pageSlider = await _dbcontext.PracticeSliders.FindAsync(id);
            if (pageSlider == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            _dbcontext.PracticeSliders.Remove(pageSlider);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/PracticeSliders/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            PracticeSlider pageSlider = _dbcontext.PracticeSliders.Find(id);
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
            PracticeSlider pageSlider = _dbcontext.PracticeSliders.Find(id);
            if (pageSlider == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(pageSlider);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PracticeSlider pageSlider)
        {
            if (!ModelState.IsValid)
            {
                return View(pageSlider);
            }
            var sliderdb = _dbcontext.PracticeSliders.Find(pageSlider.Id);
            sliderdb.Name = pageSlider.Name;
            sliderdb.Description = pageSlider.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PracticeSlider/Index");
        }
    }
}
