using Hostell.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostell.Controllers
{
    public class ResidentController:Controller
    {
        HostelAppContext db;
        public ResidentController(HostelAppContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult ResidentList()
        {
            List<Resident> residents = db.Residents.ToList();
            residents.ForEach(x => x.Block = db.Blocks.Where(b => b.Id == x.BlockId).FirstOrDefault());
            return View(residents);
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<Block> blocks = db.Blocks.ToList(); 
            ViewBag.NoBlock = new SelectList(blocks, "Id", "NoBlock");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Resident resident)
        {
            db.Residents.Add(resident);
            await db.SaveChangesAsync();
            return RedirectToAction("ResidentList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
             Resident resident = db.Residents.Where(x => x.Id == id).FirstOrDefault();
             resident.Block = db.Blocks.Where(b => b.Id == resident.BlockId).FirstOrDefault();
             return View(resident);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Resident resident)
        {
            db.Remove(resident);
            await db.SaveChangesAsync();
            return View("ResidentList");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Resident resident = db.Residents.Where(x => x.Id == id).FirstOrDefault();
            resident.Block=db.Blocks.Where(b => b.Id == resident.BlockId).FirstOrDefault();
            return View(resident);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Resident resident = db.Residents.Where(x => x.Id == id).FirstOrDefault();
            resident.Block = db.Blocks.Where(b => b.Id == resident.BlockId).FirstOrDefault();
            List<Block> blocks = db.Blocks.ToList();
            ViewBag.NoBlock = new SelectList(blocks, "Id", "NoBlock");
            return View(resident);   
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Resident resident)
        {
            db.Residents.Update(resident);
            await db.SaveChangesAsync();
            return RedirectToAction("ResidentList");
        }
    }
}
