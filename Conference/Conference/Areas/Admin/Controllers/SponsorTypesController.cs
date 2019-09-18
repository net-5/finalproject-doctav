using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SponsorTypesController : Controller
    {
        private readonly SponsorTypesService sponsorTypesService;

        public SponsorTypesController(SponsorTypesService sponsorTypesService)
        {
            this.sponsorTypesService = sponsorTypesService;
        }

        // GET: SponsorTypes
        public ActionResult Index()
        {
            List<SponsorTypes> allSponsorTypes;
            allSponsorTypes = sponsorTypesService.GetAllSponsorTypes();
            return View(allSponsorTypes);
        }

        // GET: SponsorTypes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SponsorTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SponsorTypes/Create
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

        // GET: SponsorTypes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SponsorTypes/Edit/5
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

        // GET: SponsorTypes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SponsorTypes/Delete/5
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