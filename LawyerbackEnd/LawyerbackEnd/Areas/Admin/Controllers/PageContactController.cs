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

    public class PageContactController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        public PageContactController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.PageContacts.ToList()) ;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PageContact pageContact)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await _dbcontext.PageContacts.AddAsync(pageContact);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PageContact/Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            PageContact slider = _dbcontext.PageContacts.Find(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PageContact slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }
            var sliderdb = _dbcontext.PageContacts.Find(slider.Id);
            sliderdb.Header = slider.Header;
            sliderdb.Title = slider.Title;
            sliderdb.Link = slider.Link;
            sliderdb.LinkDescription = slider.LinkDescription;
            sliderdb.Description = slider.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PageContact/Index");
        }
    }
}
