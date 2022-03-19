using LawyerbackEnd.Models;
using LawyerbackEnd.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpGet]
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                sliders = _dbcontext.Sliders.ToList(),
                holders = _dbcontext.Holders.ToList(),
                practises = _dbcontext.Practises.ToList(),
                indexChooses = _dbcontext.IndexChooses.ToList(),
                teams = _dbcontext.Teams.ToList(),
                categories = _dbcontext.Categories.ToList(),
                news = _dbcontext.News.ToList(),
                services = _dbcontext.Services.ToList(),
                ourAbouts = _dbcontext.OurAbouts.ToList(),
                pictureSliders = _dbcontext.pictureSliders.ToList(),
                biographies = _dbcontext.Biographies.ToList(),
                blogDetails = _dbcontext.BlogDetails.ToList(),
                contacts = _dbcontext.Contacts.ToList(),
                allContacts = _dbcontext.AllContactsAreas.ToList()
            };
            return View(homeVM);
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (contact == null)
            {
                return NotFound();
            }
            _dbcontext.Contacts.Add(contact);
            _dbcontext.SaveChanges();
            return Redirect("/Home/Index");
        }
        public IActionResult Pages()
        {
            HomeVM homeVM = new HomeVM
            {
                pageSliders = _dbcontext.PageSliders.ToList(),
                sliders = _dbcontext.Sliders.ToList(),
                categories = _dbcontext.Categories.ToList(),
                pageContacts = _dbcontext.PageContacts.ToList(),
                biographies = _dbcontext.Biographies.ToList()
            };
            return View(homeVM);
        }
        public IActionResult Practice()
        {
            HomeVM homeVM = new HomeVM
            {
                practiceSliders = _dbcontext.PracticeSliders.ToList(),
                practiceAbouts = _dbcontext.PracticeAbouts.ToList(),
                pageContacts = _dbcontext.PageContacts.ToList()
            };
            return View(homeVM);
        }

        public IActionResult Attorneys()
        {
            HomeVM homeVM = new HomeVM
            {
                attorneysSliders = _dbcontext.AttorneysSliders.ToList(),
                biographies = _dbcontext.Biographies.ToList(),
                attorneyWorks = _dbcontext.AttorneyWorks.ToList(),
                attorneysLogos = _dbcontext.AttorneysLogos.ToList(),
                blogDetails = _dbcontext.BlogDetails.ToList()
            };
            return View(homeVM);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Biography biography = _dbcontext.Biographies.Find(id);
            if (biography == null)
            {
                return NotFound();
            }
            return View(biography);
        }


        public IActionResult TeamAllDetails()
        {
            return View(_dbcontext.Biographies.ToList());
        }
        public IActionResult Blog()
        {
            HomeVM home = new HomeVM
            {
                blogDetails = _dbcontext.BlogDetails.ToList(),
                blogHeaders = _dbcontext.BlogHeaders.ToList(),
                blogIndexAbouts = _dbcontext.BlogIndexAbouts.ToList()
            };
            return View(home);
        }

        public IActionResult BlogDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BlogDetails blog = _dbcontext.BlogDetails.Find(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            HomeVM homes = new HomeVM
            {
                allContacts = _dbcontext.AllContactsAreas.ToList(),
                contacts = _dbcontext.Contacts.ToList()
            };
            return View(homes);
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if (contact == null)
            {
                return NotFound();
            }
            _dbcontext.Contacts.Add(contact);
            _dbcontext.SaveChanges();
            return Redirect("/Home/Contact");
        }

        public IActionResult CaseStudies()
        {
            List<Case> cases = _dbcontext.Cases.Include(c => c.categorys).ToList();
            return View(cases);
        }
        public IActionResult CaseStudiesDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Case cases = _dbcontext.Cases.Include(c => c.categorys).FirstOrDefault(i => i.Id == id);
            ViewBag.Cases = _dbcontext.Cases.Include(c => c.categorys).ToList();
            return View(cases);
            //
        }

        public IActionResult AboutMe()
        {
            HomeVM homeVM = new HomeVM
            {
                pageSliders = _dbcontext.PageSliders.ToList(),
                sliders = _dbcontext.Sliders.ToList(),
                categories = _dbcontext.Categories.ToList(),
                pageContacts = _dbcontext.PageContacts.ToList(),
                biographies = _dbcontext.Biographies.ToList(),
                practiceAbouts = _dbcontext.PracticeAbouts.ToList()
            };
            return View(homeVM);
        }

        public IActionResult Pricing()
        {
            HomeVM home = new HomeVM
            {
                biographies = _dbcontext.Biographies.ToList(),
                packetToComponents=_dbcontext.packetToComponents.ToList(),
                components=_dbcontext.Components.ToList(),
                packets=_dbcontext.Packets.ToList()
                
            };
            return View(home);
        }
        public IActionResult Faq()
        {
            HomeVM home = new HomeVM
            {
                faqs = _dbcontext.Faqs.ToList(),
                allContacts=_dbcontext.AllContactsAreas.ToList()
            };
            return View(home);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
