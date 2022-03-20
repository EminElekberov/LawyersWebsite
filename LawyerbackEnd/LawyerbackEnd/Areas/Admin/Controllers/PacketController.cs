using LawyerbackEnd.Models;
using LawyerbackEnd.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
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
        //[HttpGet]
        //public IActionResult Edit(int? id)
        //{
        //    if (id==null)
        //    {
        //        return NotFound();
        //    }
        //    var packet = _dbcontext.Packets.FirstOrDefault(dr => dr.Id == id);
        //    if (packet==null)
        //    {
        //        return NotFound();
        //    }
        //    var components = _dbcontext.packetToComponents.Where(e => e.PacketId == id).Select(z => z.componentsId).ToList();
        //    PacketVm packetVm = new PacketVm
        //    {
        //        Packets=_dbcontext.Packets.ToList(),
        //        Components=_dbcontext.Components.ToList(),
        //        PacketID=packet.Id,
        //        ComponentsId=components
        //    };
        //    return View(packetVm);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Edit(PacketVm packetVm)
        //{
        //    var package = _dbcontext.packetToComponents.Where(a => a.PacketId == packetVm.PacketID).ToList();
        //    foreach (var item in package)
        //    {
        //        _dbcontext.packetToComponents.Remove(item);
        //    }
        //    await _dbcontext.SaveChangesAsync();
        //    foreach (var item in packetVm.ComponentsId)
        //    {
        //        PacketToComponents packetTo = new PacketToComponents
        //        {
        //            PacketId = packetVm.PacketID,
        //            componentsId = item
        //        };
        //        _dbcontext.packetToComponents.Add(packetTo);
        //    }
        //    await _dbcontext.SaveChangesAsync();
        //    return Redirect("/Admin/Packet/Index");
        //}
    }
}
