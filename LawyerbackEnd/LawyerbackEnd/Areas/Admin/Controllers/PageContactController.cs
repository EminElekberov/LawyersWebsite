using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]

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
    }
}
