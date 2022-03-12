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
    }
}
