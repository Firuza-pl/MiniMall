using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Yasamall.DAL;
using Yasamall.Models;

namespace Yasamall.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HallController : Controller
    {
        private readonly Db_Yasamall _context;
        private readonly IHostingEnvironment _env;

        public HallController(Db_Yasamall context,
                              IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.Active = "Site";

            return View(_context.Halls);
        }

        [ActionName("Delete")]
        public async Task<IActionResult> DeleteGet(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            if (id == null) return View("Error");

            Halls hall = await _context.Halls.FindAsync(id);

            if (hall == null) return View("Error");

            ViewBag.Active = "Site";

            return View(hall);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }

            Halls hall = await _context.Halls.FindAsync(id);


            _context.Halls.Remove(hall);

            await _context.SaveChangesAsync();
            ViewBag.Active = "Site";

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.Active = "Home";

            ViewBag.Brands = _context.Brands.Where(b => b.IsFilm == true);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Halls hall)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Active = "Site";

                ViewBag.Brands = _context.Brands;
                return View(hall);
            }


            Halls newHall = new Halls()
            {
                Name = hall.Name,
                BrandId = hall.BrandId
            };

            await _context.Halls.AddAsync(newHall);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [ActionName("Edit")]
        public IActionResult Edit(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            if (id == null) return View("Error");

            Halls hall = _context.Halls.Find(id);

            return View(hall);
        }

        [ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Halls hall)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Xaiş olunur düzgün doldurun.");
                return View(hall);
            }

            Halls newHall = await _context.Halls.FindAsync(hall.Id);

            if (newHall == null) return View("Error");

            newHall.Name = hall.Name;

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}