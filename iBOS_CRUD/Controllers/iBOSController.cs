using iBOS_CRUD.Data;
using iBOS_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iBOS_CRUD.Controllers
{
    public class iBOSController : Controller
    {
        private readonly iBOSContext _context;
        public iBOSController(iBOSContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var displaydata = _context.tblColdDrinks.ToList();
            _context.tblColdDrinks.RemoveRange(_context.tblColdDrinks.Where(x => x.numQuantity <= 499));
            _context.SaveChanges();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(iBOS ibos)
        {
            if(ModelState.IsValid)
            {
                _context.Add(ibos);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ibos);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return RedirectToAction("Index");
            }
            var getdetails = await _context.tblColdDrinks.FindAsync(id);
            return View(getdetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(iBOS ib)
        {
            if(ModelState.IsValid)
            {
                _context.Update(ib);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ib);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getdetails = await _context.tblColdDrinks.FindAsync(id);
            return View(getdetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getdetails = await _context.tblColdDrinks.FindAsync(id);
            return View(getdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getdetails = await _context.tblColdDrinks.FindAsync(id);
            _context.tblColdDrinks.Remove(getdetails);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
