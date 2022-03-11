using LawyerbackEnd.Extension;
using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public CategoryController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.Categories.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            if (!category.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(category);
            }
            string folder = @"images\testimonials";
            var newCtImage = await category.Photo.Savepicture(env.WebRootPath, folder);
            category.Image = newCtImage;
            await _dbcontext.Categories.AddAsync(category);
            await _dbcontext.SaveChangesAsync();
            return Redirect("Index");
        } 
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = _dbcontext.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            _dbcontext.Categories.Remove(category);
            _dbcontext.SaveChanges();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Category/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var category = _dbcontext.Categories.Find(id);
            if (category==null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var category = _dbcontext.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            if (!ModelState.IsValid && category.Photo==null)
            {
                ModelState.AddModelError("photo", "Sekil daxil edin");
                return View();
            }
            var categorydb = _dbcontext.Categories.Find(category.Id);
            //if (!category.Photo.IsImage())
            //{
            //    ModelState.AddModelError("photo", "Img formati dogru deyil");
            //    return View(category);
            //}
            if (category.Photo!=null)
            {
                try
                {
                    string folder = @"images\testimonials";
                    var newCtImage = await category.Photo.Savepicture(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, categorydb.Image);
                    categorydb.Image = newCtImage;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            categorydb.Name = category.Name;
            categorydb.Company = category.Company;
            categorydb.Description = category.Description;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/Category/Index");
        }
    }
}
