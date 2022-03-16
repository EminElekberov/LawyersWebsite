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

    public class PictureSliderController : Controller
    {

        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public PictureSliderController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.pictureSliders.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PictureSlider picture)
        {
            if (!ModelState.IsValid && picture.Photo == null)
            {
                ModelState.AddModelError("photo", "Sekil daxil edin");
                return View();
            }
            if (!picture.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(picture);
            }
            string folder = @"images\holder";
            var newImg = await picture.Photo.Savepicture(env.WebRootPath, folder);
            picture.Image = newImg;
            await _dbcontext.pictureSliders.AddAsync(picture);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/PictureSlider/Index");
        }
    }
}
