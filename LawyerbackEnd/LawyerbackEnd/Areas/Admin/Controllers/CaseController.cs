using LawyerbackEnd.Extension;
using LawyerbackEnd.Models;
using LawyerbackEnd.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
   // [Authorize(Roles = "Admin")]

    public class CaseController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;

        public CaseController(LawyerDbcontext portoDbContext, IWebHostEnvironment _env)
        {
            _dbcontext = portoDbContext;
            env = _env;
        }

        public IActionResult Index()
        {
            var group = _dbcontext.Cases.Include(x => x.categorys).ToList();
            return View(group);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categorys = _dbcontext.Categorys.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Case cases)
        {
            if (!ModelState.IsValid && cases.Photo == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            if (!cases.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(cases);
            }
            string folder = @"images\aboutCase";
            var newImg = await cases.Photo.Savepicture(env.WebRootPath, folder);
            cases.Image = newImg;
            _dbcontext.Cases.Add(cases);
            _dbcontext.SaveChanges();
            return Redirect("/Admin/Case/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            Case cases = await _dbcontext.Cases.FindAsync(id);
            if (cases == null)
            {
                return Redirect("/NOtfound/index");

            }
            _dbcontext.Cases.Remove(cases);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Case/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            Case cases = _dbcontext.Cases.Find(id);
            if (cases == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(cases);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Case cases)
        {
            if (!ModelState.IsValid)
            {
                return View(cases);
            }
            var sliderdb = _dbcontext.Cases.Find(cases.Id);
            if (cases.Photo != null)
            {
                try
                {
                    string folder = @"images\aboutCase";
                    var newImg = await cases.Photo.Savepicture(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, sliderdb.Image);
                    sliderdb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            sliderdb.Challenge = cases.Challenge;
            sliderdb.Description = cases.Description;
            sliderdb.LawherFullname = cases.LawherFullname;
            sliderdb.Price = cases.Price;
            sliderdb.Result = cases.Result;
            sliderdb.Solution = cases.Solution;
            sliderdb.Time = cases.Time;
            sliderdb.Title = cases.Title;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/case/Index");
        }
    }
}
