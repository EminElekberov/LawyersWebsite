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

    public class AllContactsAreasController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        public AllContactsAreasController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.AllContactsAreas.ToList());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            AllContactsAreas contact = _dbcontext.AllContactsAreas.Find(id);
            if (contact == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(contact);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            AllContactsAreas contact = _dbcontext.AllContactsAreas.Find(id);
            if (contact == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(contact);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AllContactsAreas contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            var contactdb = _dbcontext.AllContactsAreas.Find(contact.Id);
            contactdb.AddressHeader = contact.AddressHeader;
            contactdb.Address = contact.Address;
            contactdb.ContactHeader = contact.ContactHeader;
            contactdb.ContactHeaderDescription = contact.ContactHeaderDescription;
            contactdb.OfficeHeader = contact.OfficeHeader;
            contactdb.Hours = contact.Hours;
            contactdb.PhoneHeader = contact.PhoneHeader;
            contactdb.Phone = contact.Phone;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/AllContactsAreas/Index");
        }
    }
}
