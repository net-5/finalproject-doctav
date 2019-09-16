using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conference.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TalksController : Controller
    {
        private readonly ITalksService talkService;

        public TalksController(ITalksService talkService)
        {
            this.talkService = talkService;
        }

        // GET: Talks
        public ActionResult Index()
        {
            var allTalks = talkService.GetAllTalks();
            return View(allTalks);
        }

        // GET: Talks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Talks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Talks/Create
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

        // GET: Talks/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Talks/Edit/5
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

        // GET: Talks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Talks/Delete/5
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