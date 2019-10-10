using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SponsorsController : Controller
    {
        private readonly ISponsorsService sponsorsService;

        public SponsorsController(ISponsorsService sponsorsService)
        {
            this.sponsorsService = sponsorsService;
        }

        // GET: Sponsors
        public ActionResult Index()
        {
            List<Sponsors> sponsors;
            sponsors = sponsorsService.GetAllSponsors();
            return View(sponsors);
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
        public ActionResult Create(SponsorsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Sponsors sponsor = new Sponsors();
                sponsor.InjectFrom(model);
                Sponsors addedSponsor = sponsorsService.AddSponsors(sponsor);
                if(addedSponsor!=null)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("Name", "It seems there is an error about the entity...");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("Name", "It seems there is an error on the model...");
                return View(model);
            }
        }

        // GET: Sponsors/Edit/5
        public ActionResult Edit(int id)
        {
            Sponsors sponsorToEdit = sponsorsService.GetSponsorById(id);
            if(sponsorToEdit!=null)
            {
                SponsorsViewModel model = new SponsorsViewModel();
                model.InjectFrom(sponsorToEdit);
                return View(model);
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
            
        }

        // POST: Sponsors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorsViewModel model)
        {
            if (ModelState.IsValid)
            {
                Sponsors sponsorToUpdate = new Sponsors();
                sponsorToUpdate.InjectFrom(model);
                TryUpdateModelAsync(sponsorToUpdate);
                sponsorsService.UpdateSponsors(sponsorToUpdate);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Name", "It seems there is a problem with the model...");
                return View(model);
            }
        }

        // GET: Sponsors/Delete/5
        public ActionResult Delete(int id)
        {
            Sponsors sponsorToDelete = sponsorsService.GetSponsorById(id);
            if(sponsorToDelete!=null)
            {
                sponsorsService.DeleteSponsor(sponsorToDelete);
            }
            return RedirectToAction(nameof(Index));
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