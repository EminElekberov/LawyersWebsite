using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        public ServiceController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.Services.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Service service)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await _dbcontext.Services.AddAsync(service);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Service/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Service service = await _dbcontext.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            _dbcontext.Services.Remove(service);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Service/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            Service service = _dbcontext.Services.Find(id);
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
            Service service = _dbcontext.Services.Find(id);
            if (service == null)
            {
                return NotFound();
            }
            return View(service);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Service service)
        {
            if (!ModelState.IsValid)
            {
                return View(service);
            }
            var servicedb = _dbcontext.Services.Find(service.Id);
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
