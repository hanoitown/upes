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
        public ActionResult Create(Department department)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _repo.Departments.Add(department);
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
            var faculties = _repo.Faculties.All;
            var department = _repo.Departments.All.Single(d => d.Id == id);

            var vm = new DepartmentInputModel(department, faculties);

            return View(vm);
        }

        //
        // POST: /Department/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Department department)
        {
            try
            {
                // TODO: Add update logic here
                var item = _repo.Departments.All.Single(d => d.Id == id);
                item.Name = department.Name;
                item.Code = department.Code;
                item.FacultyId = department.FacultyId;

                _repo.SaveChanges();

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
            var faculties = _repo.Faculties.All;
            var department = _repo.Departments.All.Single(d => d.Id == id);

            var vm = new DepartmentInputModel(department, faculties);

            return View(vm);
        }

        //
        // POST: /Department/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var department = _repo.Departments.All.Single(d => d.Id == id);
                _repo.Departments.Remove(department);
                _repo.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
