using LawyerbackEnd.Models;
using LawyerbackEnd.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class PacketController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        public PacketController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            ViewBag.PacketToComponents = _dbcontext.packetToComponents.Include(x => x.components).Include(y => y.packet).ToList();
            return View(_dbcontext.Packets.Include(x=>x.packetToComponents).ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Components = _dbcontext.Components.ToList();
            ViewBag.Packets = _dbcontext.Packets.ToList();
            //{
            //    PacketVm packetVm = new PacketVm
            //    {
            //        Packets = _dbcontext.Packets.ToList(),
            //        Components = _dbcontext.Components.ToList()
            //    };
            //    return View(packetVm);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PacketVm packet)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Error", "Error");
                return View();
            }
            PacketToComponents packetToComponents = new PacketToComponents();
            foreach (var item in packet.ComponentsId)
            {
                PacketToComponents packetTo = new PacketToComponents
                {
                    PacketId = packet.PacketID,
                    componentsId = item
                };
                _dbcontext.packetToComponents.Add(packetTo);
            }
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/packet/Index");
        }
        public IActionResult CreateModal()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CreateModal(string name)
        {
            if (name == null)
            {
                return Json(new
                {
                    status = 400
                });
            }
            Packet packet = new Packet
            {
                Name = name
            };
            _dbcontext.Packets.Add(packet);
            _dbcontext.SaveChanges();
            return Json(new
            {
                status = 200
            });
        }
            [HttpGet]
        public IActionResult ComponentsCreate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ComponentsCreate(Components components)
        {
            if (components==null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            _dbcontext.Components.Add(components);
            _dbcontext.SaveChanges();
            return Redirect("/Admin/packet/index");
        }

        public IActionResult Edit(int? id)
        {
            ViewBag.Practices = _dbcontext.Components.ToList();
            ViewBag.PacketToComponents = _dbcontext.packetToComponents.Where(k => k.PacketId == id).ToList();

            Packet price = _dbcontext.Packets.FirstOrDefault(i => i.Id == id);
            return View(price);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Packet price)
        {
            if (!ModelState.IsValid)
            {
                return View(price);
            }

            List<PacketToComponents> teacherHobbies = await _dbcontext.packetToComponents.Where(t => t.PacketId == price.Id).ToListAsync();
            _dbcontext.packetToComponents.RemoveRange(teacherHobbies);
            price.packetToComponents = new List<PacketToComponents>();
            foreach (var id in price.ComponentsID)
            {
                PacketToComponents ppracitce = new PacketToComponents
                {
                    PacketId = price.Id,
                    componentsId = id
                };
                _dbcontext.packetToComponents.Add(ppracitce);
            }
            await _dbcontext.SaveChangesAsync();

            return LocalRedirect("/Admin/Packet/Index");
        }
    }
}
