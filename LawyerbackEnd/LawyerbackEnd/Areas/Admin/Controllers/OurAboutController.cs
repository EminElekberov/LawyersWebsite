using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OurAboutController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        public OurAboutController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            return View(_dbcontext.OurAbouts.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(OurAbout ourAbout)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await _dbcontext.OurAbouts.AddAsync(ourAbout);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/OurAbout/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            OurAbout choose = await _dbcontext.OurAbouts.FindAsync(id);
            if (choose == null)
            {
                return NotFound();
            }
            _dbcontext.OurAbouts.Remove(choose);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/OurAbout/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            OurAbout ourAbout = _dbcontext.OurAbouts.Find(id);
            if (ourAbout==null)
            {
                return NotFound();
            }
            return View(ourAbout);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(OurAbout ourAbout)
        {
            if (ourAbout==null)
            {
                return NotFound();
            }
            OurAbout our = _dbcontext.OurAbouts.Find(ourAbout.Id);
            if (our==null)
            {
                return NotFound();
            }
            our.Header = ourAbout.Header;
            our.headerUndeer = ourAbout.headerUndeer;
            our.Price = ourAbout.Price;
            our.Dates = ourAbout.Dates;
            our.Description = ourAbout.Description;
            our.Description2 = ourAbout.Description2;
            our.Description3 = ourAbout.Description3;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/OurAbout/Index");
        }

    }
}
