using LawyerbackEnd.Models;
using LawyerbackEnd.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;

        public HomeController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                sliders = _dbcontext.Sliders.ToList(),
                holders = _dbcontext.Holders.ToList(),
                practises = _dbcontext.Practises.ToList(),
                indexChooses = _dbcontext.IndexChooses.ToList(),
                teams=_dbcontext.Teams.ToList(),
                categories=_dbcontext.Categories.ToList(),
                news=_dbcontext.News.ToList(),
                services=_dbcontext.Services.ToList(),
                ourAbouts=_dbcontext.OurAbouts.ToList(),
                pictureSliders=_dbcontext.pictureSliders.ToList()
            };
            return View(homeVM);
        }

        public IActionResult Pages()
        {
            HomeVM homeVM = new HomeVM
            {
                pageSliders = _dbcontext.PageSliders.ToList()
            };
            return View(homeVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
