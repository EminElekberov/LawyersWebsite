using LawyerbackEnd.Extension;
using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PractiseController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        public PractiseController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.Practises.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Practise practise = new Practise();
            return View(practise);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Practise practise)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/NOtfound/index");

            }
            await _dbcontext.Practises.AddAsync(practise);
            await _dbcontext.SaveChangesAsync();
            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var parctise = _dbcontext.Practises.Find(id);
            if (parctise == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(parctise);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Practise practise)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var pr = _dbcontext.Practises.Find(practise.Id);
            if (pr == null)
            {
                return Redirect("/NOtfound/index");

            }
            pr.Link = practise.Link;
            pr.Description = practise.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Practise/Index");
        }

        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var search = _dbcontext.Practises.Find(id);
            if (search==null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(search);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var search = _dbcontext.Practises.Find(id);
            if (search == null)
            {
                return Redirect("/NOtfound/index");

            }
            _dbcontext.Practises.Remove(search);
            _dbcontext.SaveChanges();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Practise/Index");
        }
    }
}
