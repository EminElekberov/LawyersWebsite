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

    public class PracticeAboutController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public PracticeAboutController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.PracticeAbouts.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PracticeAbout practice)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Error", "Error");
                return View();
            }
            await _dbcontext.PracticeAbouts.AddAsync(practice);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PracticeAbout/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            PracticeAbout practice = await _dbcontext.PracticeAbouts.FindAsync(id);
            if (practice == null)
            {
                return Redirect("/NOtfound/index");

            }
            _dbcontext.PracticeAbouts.Remove(practice);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/PracticeAbout/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            PracticeAbout practice = _dbcontext.PracticeAbouts.Find(id);
            if (practice == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(practice);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            PracticeAbout practice = _dbcontext.PracticeAbouts.Find(id);
            if (practice == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(practice);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PracticeAbout practice)
        {
            if (!ModelState.IsValid)
            {
                return View(practice);
            }
            var sliderdb = _dbcontext.PracticeAbouts.Find(practice.Id);
            sliderdb.IconLink = practice.IconLink;
            sliderdb.Header = practice.Header;
            sliderdb.Learntext = practice.Learntext;
            sliderdb.LearnLink = practice.LearnLink;
            sliderdb.Description = practice.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PracticeAbout/Index");
        }
    }
}
