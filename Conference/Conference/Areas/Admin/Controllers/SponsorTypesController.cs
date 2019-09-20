using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Domain.Entities;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Conference.Areas.Admin.Models;
using Omu.ValueInjecter;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SponsorTypesController : Controller
    {
        private readonly ISponsorTypesService sponsorTypesService;

        public SponsorTypesController(ISponsorTypesService sponsorTypesService)
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
            SponsorTypes sponsorType = sponsorTypesService.GetSponsorTypesById(id);
            SponsorTypesViewModel model = new SponsorTypesViewModel();
            model.InjectFrom(sponsorType);
            return View(model);
        }

        // GET: SponsorTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SponsorTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SponsorTypesViewModel model)
        {
         if(ModelState.IsValid)
            {
                SponsorTypes sponsorType = new SponsorTypes();
                sponsorType.InjectFrom(model);
                var newSponsorType = sponsorTypesService.AddSponsorTypes(sponsorType);
                if(newSponsorType==null)
                {
                    ModelState.AddModelError("Name", "Probabibly there is an error.");
                    return View(model);
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
         else
            {
                return View(model);
            }
        }

        // GET: SponsorTypes/Edit/5
        public ActionResult Edit(int id)
        {
            SponsorTypesViewModel model = new SponsorTypesViewModel();
            SponsorTypes sponsorType = sponsorTypesService.GetSponsorTypesById(id);
            model.InjectFrom(sponsorType);
            return View(model);
        }

        // POST: SponsorTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SponsorTypesViewModel model)
        {
            if (ModelState.IsValid)
            {
                SponsorTypes sponsorTypes = sponsorTypesService.GetSponsorTypesById(id);
                sponsorTypes.InjectFrom(model);
                TryUpdateModelAsync(sponsorTypes);
                sponsorTypesService.UpdateSponsorTypes(sponsorTypes);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Name", "It seems there is an error...");
                return View(model);
            }
        }

        // GET: SponsorTypes/Delete/5
        public ActionResult Delete(int id)
        {
            SponsorTypes sponsorType;
            sponsorType = sponsorTypesService.GetSponsorTypesById(id);
            if (sponsorType != null)
            {
                sponsorTypesService.DeleteSponsorTypes(sponsorType);
            }
            return RedirectToAction(nameof(Index));
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