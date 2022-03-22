using LawyerbackEnd.Extension;
using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin
{
    [Area("Admin")]
    public class FaqController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public FaqController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.Faqs.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            Faq faqs = new Faq();
            return View(faqs);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Faq faqs)
        {
            if (!ModelState.IsValid && faqs.Photo == null)
            {
                ModelState.AddModelError("photo", "Sekil daxil edin");
                return View();
            }
            if (!faqs.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(faqs);
            }
            string folder = @"images\faq";
            var newImg = await faqs.Photo.Savepicture(env.WebRootPath, folder);
            faqs.Image = newImg;
            await _dbcontext.Faqs.AddAsync(faqs);
            await _dbcontext.SaveChangesAsync();
            return Redirect("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            Faq faqs = await _dbcontext.Faqs.FindAsync(id);
            if (faqs == null)
            {
                return Redirect("/NOtfound/index");

            }
            _dbcontext.Faqs.Remove(faqs);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "faqs silindi";
            return Redirect("/Admin/faqs/Index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            Faq faqs = _dbcontext.Faqs.Find(id);
            if (faqs == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            return View(faqs);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            Faq faqs = _dbcontext.Faqs.Find(id);
            if (faqs == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            return View(faqs);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Faq faqs)
        {
            if (!ModelState.IsValid)
            {
                return View(faqs);
            }
            var faqsDb = _dbcontext.Faqs.Find(faqs.id);
            if (faqs.Photo != null)
            {
                try
                {
                    string folder = @"images\faq";
                    var newImg = await faqs.Photo.Savepicture(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, faqsDb.Image);
                    faqsDb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            faqsDb.Question1 = faqs.Question1;
            faqsDb.Question2 = faqs.Question2;
            faqsDb.Question3 = faqs.Question3;
            faqsDb.Question4 = faqs.Question4;
            faqsDb.Questiontext1 = faqs.Questiontext1;
            faqsDb.Questiontext2 = faqs.Questiontext2;
            faqsDb.QuestionText3 = faqs.QuestionText3;
            faqsDb.QuestionText4 = faqs.QuestionText4;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/faq/Index");
        }
    }
}
