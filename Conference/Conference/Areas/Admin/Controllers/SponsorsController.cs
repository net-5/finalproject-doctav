using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SponsorsController : Controller
    {
        // GET: Sponsors
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sponsors/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sponsors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sponsors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Sponsors/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sponsors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Sponsors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sponsors/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}