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
    public class AttorneysSliderController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public AttorneysSliderController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.AttorneysSliders.ToList());
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AttorneysSlider attorneys = await _dbcontext.AttorneysSliders.FindAsync(id);
            if (attorneys == null)
            {
                return NotFound();
            }
            _dbcontext.AttorneysSliders.Remove(attorneys);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/AttorneysSlider/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            AttorneysSlider attorneys = _dbcontext.AttorneysSliders.Find(id);
            if (attorneys == null)
            {
                return NotFound();
            }
            return View(attorneys);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AttorneysSlider attorneys = _dbcontext.AttorneysSliders.Find(id);
            if (attorneys == null)
            {
                return NotFound();
            }
            return View(attorneys);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AttorneysSlider pageSlider)
        {
            if (!ModelState.IsValid)
            {
                return View(pageSlider);
            }
            var sliderdb = _dbcontext.AttorneysSliders.Find(pageSlider.Id);
            sliderdb.Name = pageSlider.Name;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/AttorneysSlider/Index");
        }
    }
}
