using LawyerbackEnd.Extension;
using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class AttorneysBioController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public AttorneysBioController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.Biographies.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Biography biography)
        {
            if (!ModelState.IsValid && biography.Photo == null)
            {
                ModelState.AddModelError("photo", "Sekil daxil edin");
                return View();
            }
            if (!biography.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(biography);
            }
            string folder = @"images\attorneys";
            var newImg = await biography.Photo.Savepicture(env.WebRootPath, folder);
            biography.Image = newImg;
            await _dbcontext.Biographies.AddAsync(biography);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/AttorneysBio/Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            Biography biography = await _dbcontext.Biographies.FindAsync(id);
            if (biography == null)
            {
                return Redirect("/NOtfound/index");

            }
            _dbcontext.Biographies.Remove(biography);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/AttorneysBio/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View();
            }
            Biography biography = _dbcontext.Biographies.Find(id);
            if (biography == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(biography);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");
            }
            Biography biography = _dbcontext.Biographies.Find(id);
            if (biography == null)
            {
                return Redirect("/NOtfound/index");

            }
            return View(biography);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Biography biography)
        {
            if (!ModelState.IsValid)
            {
                return View(biography);
            }
            var biographydb = _dbcontext.Biographies.Find(biography.Id);
            if (biography.Photo != null)
            {
                try
                {
                    string folder = @"images\attorneys";
                    var newImg = await biography.Photo.Savepicture(env.WebRootPath, folder);
                    FileExtension.DeleteImage(env.WebRootPath, folder, biographydb.Image);
                    biographydb.Image = newImg;
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "Unexpected error while save img");
                    throw;
                }
            }
            biographydb.BioHeader = biography.BioHeader;
            biographydb.BioDescription = biography.BioDescription;
            biographydb.EducationHeader = biography.EducationHeader;
            biographydb.EducationDescription = biography.EducationDescription;
            biographydb.Aphorizm = biography.Aphorizm;
            biographydb.AwarsHeader = biography.AwarsHeader;
            biographydb.AwardDescription = biography.AwardDescription;
            biographydb.AwardIconsDesc = biography.AwardIconsDesc;
            biographydb.Job = biography.Job;
            biographydb.Name = biography.Name;
            biographydb.Comminucate = biography.Comminucate;
            biographydb.IconsComminucate = biography.IconsComminucate;
            biographydb.IconsComminucate2 = biography.IconsComminucate2;
            biographydb.IconsComminucate3 = biography.IconsComminucate3;
            biographydb.PractiseHeader = biography.PractiseHeader;
            biographydb.PrcatiseDesc = biography.PrcatiseDesc;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/AttorneysBio/Index");
        }
    }
}
