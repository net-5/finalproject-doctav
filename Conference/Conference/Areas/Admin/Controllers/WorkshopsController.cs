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
    public class WorkshopsController : Controller
    {
        private readonly IWorkshopService workshopService;

        public WorkshopsController(IWorkshopService workshopService)
        {
            this.workshopService = workshopService;
        }
        // GET: Workshops
        public ActionResult Index()
        {
            var allWorkshops = workshopService.GetAllWorkshops();
            return View(allWorkshops);
        }

        // GET: Workshops/Details/5
        public ActionResult Details(int id)
        {
            Workshops model;
            model = workshopService.GetWorkshopById(id);
            return View(model);
        }

        // GET: Workshops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workshops/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Workshops model)
        {
            if(ModelState.IsValid)
            {
                Workshops addedWorkshop = workshopService.AddWorkshop(model);
                if (addedWorkshop==null)
                {
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

        // GET: Workshops/Edit/5
        public ActionResult Edit(int id)
        {
            Workshops editedWorkshop;
            editedWorkshop = workshopService.GetWorkshopById(id);
            return View(editedWorkshop);
        }

        // POST: Workshops/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Workshops model)
        {
            if (ModelState.IsValid)
            {
                Workshops workshopToUpdate = workshopService.GetWorkshopById(id);
                TryUpdateModelAsync(workshopToUpdate);
                Workshops updatedWorkshop= workshopService.UpdateWorkshop(workshopToUpdate);
                if (updatedWorkshop != null)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

        // GET: Workshops/Delete/5
        public ActionResult Delete(int id)
        {
            Workshops workshopToDelete = workshopService.GetWorkshopById(id);
            workshopService.DeleteWorkshop(workshopToDelete);
            return RedirectToAction(nameof(Index));
        }

        // POST: Workshops/Delete/5
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