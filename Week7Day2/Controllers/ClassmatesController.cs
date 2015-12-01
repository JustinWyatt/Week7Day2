using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week7Day2.Models;

namespace Week7Day2.Controllers
{
    public class ClassmatesController : Controller
    {
        
        // GET: Classmates
        public ActionResult List()
        {
            var classmates = new Classmate()
            {
                FirstName = "Justin",
                LastName = "Wyatt",
                School = "The Iron Yard",
                Graduation = DateTime.Parse("1/22/2016"),
                Awards = "Certificate",
                Photo = "https://avatars2.githubusercontent.com/u/14715904?v=3&s=460"

            };

            return View(classmates);
        }

        // GET: Classmates/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Classmates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Classmates/Create
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

        // GET: Classmates/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Classmates/Edit/5
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

        // GET: Classmates/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Classmates/Delete/5
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
