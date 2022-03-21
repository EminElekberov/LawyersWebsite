using LawyerbackEnd.Extension;
using LawyerbackEnd.Models;
using LawyerbackEnd.Models.AdminAccount;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSendMessage _emailSend;
        public AccountController(LawyerDbcontext portoDbContext, 
            UserManager<User> userManager, 
            RoleManager<IdentityRole> roleManager, 
            SignInManager<User> signInManager,
            IEmailSendMessage emailSend)
        {
            _dbcontext = portoDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _emailSend = emailSend;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var result = await _signInManager.PasswordSignInAsync(user.Email, user.PasswordHash, false, false);
            if (result.Succeeded)
            {
                return Redirect("/Admin/Slider/Index");
            }
            return View(user);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Register register)
        {
            if (_userManager.FindByEmailAsync(register.Email).Result == null)
            {
                User user = new User
                {
                    UserName = register.Email
                };
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "User").Wait();
                    await _signInManager.SignInAsync(user, false);
                    return Redirect("/Admin/Account/Login");
                }
            }
            return View(register);
        }
        public async Task SeedRoles()
        {
            if (!await _roleManager.RoleExistsAsync(roleName: "Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "Admin"));
            }
            if (!await _roleManager.RoleExistsAsync(roleName: "User"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "User"));
            }
        }
        public async Task SeedAdmin()
        {
            if (_userManager.FindByEmailAsync("eminelekberov09@gmail.com").Result == null)
            {
                User user = new User
                {
                    UserName = "emin",
                    Email = "eminelekberov09@gmail.com"
                };
                var result = await _userManager.CreateAsync(user, "emin123!A");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                    await _dbcontext.SaveChangesAsync();
                    await _signInManager.SignInAsync(user, true);
                }
            }
        }
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPassword forgetPassword)
        {
            User user = await _userManager.FindByEmailAsync(forgetPassword.Email);
            if (user==null)
            {
                return NotFound();
            }
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            string call = Url.Action("resetpassword", "account", new { token, email = user.Email }, Request.Scheme);
            string body = string.Empty;
            using (StreamReader stream=new StreamReader("wwwroot/templates/forgetpasswod.html"))
            {
                body = stream.ReadToEnd();
            }
            body = body.Replace("{{url}}", call);
            _emailSend.SendMEssage(user.Email, "Reset Password", body);
            return Redirect("/Admin/Account/Login");
        }
        public IActionResult ResetPassword(string token,string email)
        {
            //
            ResetPassword reset = new ResetPassword
            {
                Token=token,
                Email=email
            };
            return View(reset);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPassword reset)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            User user = await _userManager.FindByEmailAsync(reset.Email);
            var result = await _userManager.ResetPasswordAsync(user, reset.Token, reset.Password);
            if (!result.Succeeded)
            {
                return NotFound();
            }
            return Redirect("/Admin/Account/Login");
        }
    }
}
