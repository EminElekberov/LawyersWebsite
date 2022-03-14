﻿using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Contact contact = await _dbcontext.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
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
                return NotFound();
            }
            return View(contact);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Contact contact = _dbcontext.Contacts.Find(id);
            if (contact == null)
            {
                return NotFound();
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
