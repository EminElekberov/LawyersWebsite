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

    public class AttorneysLogoController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public AttorneysLogoController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.AttorneysLogos.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AttorneysLogo slider)
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
            string folder = @"images\Logo";
            var newImg = await slider.Photo.Savepicture(env.WebRootPath, folder);
            slider.Image = newImg;
            await _dbcontext.AttorneysLogos.AddAsync(slider);
            await _dbcontext.SaveChangesAsync();
            return Redirect("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AttorneysLogo logo = await _dbcontext.AttorneysLogos.FindAsync(id);
            if (logo == null)
            {
                return NotFound();
            }
            _dbcontext.AttorneysLogos.Remove(logo);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/AttorneysLogo/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            AttorneysLogo logo = _dbcontext.AttorneysLogos.Find(id);
            if (logo == null)
            {
                return NotFound();
            }
            return View(logo);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AttorneysLogo logo = _dbcontext.AttorneysLogos.Find(id);
            if (logo == null)
            {
                return NotFound();
            }
            return View(logo);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AttorneysLogo slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }
            var sliderdb = _dbcontext.AttorneysLogos.Find(slider.Id);
            if (slider.Photo != null)
            {
                try
                {
                    string folder = @"images\Logo";
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
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/AttorneysLogo/Index");
        }
    }
}
