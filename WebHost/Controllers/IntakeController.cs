using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPES.Core.Interfaces;

namespace WebHost.Controllers
{
    public class IntakeController : BaseController
    {
        public IntakeController(IStudentAdmin repo)
            : base(repo)
        {

        }
        //
        // GET: /Intake/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Intake/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Intake/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Intake/Create
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

        //
        // GET: /Intake/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Intake/Edit/5
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

        //
        // GET: /Intake/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Intake/Delete/5
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
