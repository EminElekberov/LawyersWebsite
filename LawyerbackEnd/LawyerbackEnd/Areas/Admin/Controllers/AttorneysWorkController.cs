using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AttorneysWorkController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        public AttorneysWorkController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.AttorneyWorks.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AttorneyWork service)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await _dbcontext.AttorneyWorks.AddAsync(service);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/AttorneyWork/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AttorneyWork service = await _dbcontext.AttorneyWorks.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            _dbcontext.AttorneyWorks.Remove(service);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/AttorneyWork/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            AttorneyWork service = _dbcontext.AttorneyWorks.Find(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AttorneyWork service = _dbcontext.AttorneyWorks.Find(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AttorneyWork service)
        {
            if (!ModelState.IsValid)
            {
                return View(service);
            }
            var servicedb = _dbcontext.AttorneyWorks.Find(service.Id);
            servicedb.Header = service.Header;
            servicedb.Title = service.Title;
            servicedb.Description = service.Description;
            servicedb.Buttontext = service.Buttontext;
            servicedb.ButtonLink = service.ButtonLink;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Service/Index");
        }
    }
}
