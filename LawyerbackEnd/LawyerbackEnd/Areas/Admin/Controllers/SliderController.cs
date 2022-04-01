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
    public class SliderController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public SliderController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.Sliders.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Slider slider = new Slider();
            return View(slider);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid && slider.Photo == null)
            {
                ModelState.AddModelError("photo", "Sekil daxil edin");
                return View();
            }
            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(slider);
            }
            string folder = @"images\home";
            var newImg = await slider.Photo.Savepicture(env.WebRootPath, folder);
            slider.Image = newImg;
            await _dbcontext.Sliders.AddAsync(slider);
            await _dbcontext.SaveChangesAsync();
            return Redirect("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            Slider slider = await _dbcontext.Sliders.FindAsync(id);
            if (slider == null)
            {
                return Redirect("/NOtfound/index");
            }
            _dbcontext.Sliders.Remove(slider);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Slider/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            Slider slider = _dbcontext.Sliders.Find(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            Slider slider = _dbcontext.Sliders.Find(id);
            if (slider == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(slider);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/NOtfound/index");

            }
            var sliderdb = _dbcontext.Sliders.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\home";
                    var newImg = await slider.Photo.Savepicture(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, sliderdb.Image);
                    sliderdb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            sliderdb.Name = slider.Name;
            sliderdb.Description = slider.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Slider/Index");
        }

    }
}
