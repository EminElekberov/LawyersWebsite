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
    public class TeamController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly IWebHostEnvironment env;
        public TeamController(LawyerDbcontext dbcontext, IWebHostEnvironment _env)
        {
            _dbcontext = dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.Teams.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Teams teams)
        {
            if (!ModelState.IsValid && teams.Photo==null)
            {
                ModelState.AddModelError("photo", "Sekil daxil edin");
                return View();
            }
            var teamsDB = _dbcontext.Teams.Find(teams.Id);
            if (!teams.Photo.IsImage())
            {
                ModelState.AddModelError("photo", "Img formati dogru deyil");
                return View(teams);
            }
            string folder = @"images\team";
            var teamImg = await teams.Photo.Savepicture(env.WebRootPath, folder);
            teams.Image = teamImg;
            await _dbcontext.Teams.AddAsync(teams);
            await _dbcontext.SaveChangesAsync();
            return Redirect("Index");
        }
    }
}
