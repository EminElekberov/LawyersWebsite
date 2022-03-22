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

    public class ContactController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        public ContactController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.Contacts.ToList());
        }
        public IActionResult AllContactIndex()
        {
            return View(_dbcontext.Contacts.ToList());
        }
        [HttpGet]
        public IActionResult CreateOpinion(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            Contact contact = _dbcontext.Contacts.Find(id);
            if (contact == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(contact);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOpinion(Contact contact)
        {
            #region
            //if (!ModelState.IsValid)
            //{
            //    ModelState.AddModelError("Error", "Error");
            //    return View();
            //}
            //await _dbcontext.Contacts.AddAsync(contact);
            //await _dbcontext.SaveChangesAsync();
            //return Redirect("Index");
            #endregion
            if (ModelState.IsValid)
            {
                return View(contact);
            }
            var sliderdb = _dbcontext.Contacts.Find(contact.Id);
            sliderdb.MyOpinion = contact.MyOpinion;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Contact/Index");

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            Contact contact = await _dbcontext.Contacts.FindAsync(id);
            if (contact == null)
            {
                return Redirect("/NOtfound/index");

            }
            _dbcontext.Contacts.Remove(contact);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Contact/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            Contact contact = _dbcontext.Contacts.Find(id);
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
            Contact contact = _dbcontext.Contacts.Find(id);
            if (contact == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(contact);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            //var contactdb = _dbcontext.Contacts.Find(contact.Id);
            //contactdb.AddressHeader = contact.AddressHeader;
            //contactdb.Address = contact.Address;
            //contactdb.ContactHeader = contact.ContactHeader;
            //contactdb.ContactHeaderDescription = contact.ContactHeaderDescription;
            //contactdb.OfficeHeader = contact.OfficeHeader;
            //contactdb.Hours = contact.Hours;
            //contactdb.PhoneHeader = contact.PhoneHeader;
            //contactdb.Phone = contact.Phone;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Contact/Index");
        }
    }
}
