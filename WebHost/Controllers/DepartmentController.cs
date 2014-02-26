using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPES.Core.Interfaces;
using UPES.Core.Models;
using WebHost.Models;

namespace WebHost.Controllers
{
    public class DepartmentController : BaseController
    {
        public DepartmentController(IStudentAdmin repo)
            : base(repo)
        {

        }

        //
        // GET: /Department/
        public ActionResult Index()
        {
            return View(_repo.Departments.All);
        }

        //
        // GET: /Department/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Department/Create
        public ActionResult Create()
        {
            var faculties = _repo.Faculties.All;
            var department = new Department();

            var vm = new DepartmentInputModel(department, faculties);
            return View(vm);
        }

        //
        // POST: /Department/Create
        [HttpPost]
        public ActionResult Create(Department item)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _repo.Departments.Add(item);
                    _repo.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Department/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Department/Edit/5
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
        // GET: /Department/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Department/Delete/5
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
