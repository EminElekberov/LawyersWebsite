using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly LawyerDbcontext dbcontext;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Ide>
        public IActionResult Index()
        {
            return View();
        }
    }
}
