using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace Assignment2.Controllers
{
    public class TracksController : Controller
    {

        private Manager m = new Manager();

        // GET: Tracks
        public ActionResult Index()
        {
            var t = m.TrackGetAll();
            return View(t); 
        }

        public ActionResult PopTracks()
        {
            var t = m.TrackGetAllPop();
            return View("index", t);
        }
        public ActionResult DeepPurple()
        {
            var t = m.TrackGetDeepPurple();
            return View("index", t);
        }
        public ActionResult LongestTracks()
        {
            var t = m.TrackGetAllTop100Longest();
            return View("index", t);
        }



        // GET: Tracks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tracks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tracks/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tracks/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tracks/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tracks/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tracks/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
