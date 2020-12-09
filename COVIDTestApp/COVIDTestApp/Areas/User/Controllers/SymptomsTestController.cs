using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19App.Data;
using Covid19App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Covid19App.Areas.User.Controllers
{
    public class SymptomsTestController : Controller
    {

        private readonly ApplicationDbContext _db;
        public SymptomsTestController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        [Area("User")]
        public async Task <IActionResult> Index()
        {
            return View(await _db.SymptomsTest.ToListAsync());
        }
        [Area("User")]
        
        public IActionResult Create()
        {
            return View();
        }
        [Area ("User")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(SymptomsTest symptomsTest)
        {
            if (ModelState.IsValid)
            {
                _db.SymptomsTest.Add(symptomsTest);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(symptomsTest);
        }

        [Area("User")]
        public async Task <IActionResult> Edit(int?id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var symptomsTest = await _db.SymptomsTest.FindAsync(id);
            if (symptomsTest == null)
            {
                return NotFound();
            }
            return View(symptomsTest);
        }
        [Area("User")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit (SymptomsTest symptomsTest)
        {
            if (ModelState.IsValid)
            {
                _db.Update(symptomsTest);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(symptomsTest);
        }

        [Area("User")]
        public async Task<IActionResult> Delete (int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var symptomsTest = await _db.SymptomsTest.FindAsync(id);
            if (symptomsTest == null)
            {
                return NotFound();
            }
            return View(symptomsTest);
        }
        [Area("User")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task <IActionResult>DeleteConfirmed (int? id)
        {
            var symptomsTest = await _db.SymptomsTest.FindAsync(id);
           if (symptomsTest == null)
            {
                return NotFound();
            }
            _db.SymptomsTest.Remove(symptomsTest);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        [Area("User")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var symptomsTest = await _db.SymptomsTest.FindAsync(id);
            if (symptomsTest == null)
            {
                return NotFound();
            }
            return View(symptomsTest);
        }
    }


}
