﻿using LawyerbackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawyerbackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly LawyerDbcontext _dbcontext;
        public AboutController(LawyerDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public IActionResult Index()
        {
            return View(_dbcontext.IndexChooses.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(IndexChoose indexChoose)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await _dbcontext.IndexChooses.AddAsync(indexChoose);
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/About/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            IndexChoose choose = _dbcontext.IndexChooses.Find(id);
            if (choose == null)
            {
                return NotFound();
            }
            return View(choose);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(IndexChoose choose)
        {
            if (!ModelState.IsValid)
            {
                return View(choose);
            }
            var chosedb = _dbcontext.IndexChooses.Find(choose.Id);
            chosedb.Textone = choose.Textone;
            chosedb.TextTwo = choose.TextTwo;
            chosedb.numberOne = choose.numberOne;
            chosedb.numberTwo = choose.numberTwo;
            chosedb.numberThree = choose.numberThree;
            chosedb.numberFour = choose.numberFour;
            chosedb.numbroneDesc = choose.numbroneDesc;
            chosedb.numbrTWoDesc = choose.numbrTWoDesc;
            chosedb.numbrThreeDesc= choose.numbrThreeDesc;
            chosedb.numbFourDesc= choose.numbFourDesc;
            await _dbcontext.SaveChangesAsync();
            return Redirect("/Admin/About/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            IndexChoose choose = await _dbcontext.IndexChooses.FindAsync(id);
            if (choose == null)
            {
                return NotFound();
            }
            _dbcontext.IndexChooses.Remove(choose);
            await _dbcontext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/About/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var findId = _dbcontext.IndexChooses.Find(id);
            if (findId==null)
            {
                return NotFound();
            }
            return View(findId);
        }
    }
}
