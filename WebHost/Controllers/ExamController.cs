using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPES.Core.Interfaces;
using UPES.Core.Models;
using WebHost.Models;

namespace WebHost.Controllers
{
    public class ExamController : BaseController
    {
        public ExamController(IStudentAdmin repo)
            : base(repo)
        {

        }
        //
        // GET: /Exam/
        public ActionResult Index()
        {
            return View(_repo.Exams.All);
        }

        //
        // GET: /Exam/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Exam/Create
        public ActionResult Create()
        {
            var courses = _repo.Courses.All;
            var exam = new Exam();

            var vm = new ExamInputModel(exam, courses);
            return View(vm);
        }

        //
        // POST: /Exam/Create
        [HttpPost]
        public ActionResult Create(Exam exam)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _repo.Exams.Add(exam);
                    _repo.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //
        // GET: /Exam/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Exam/Edit/5
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
        // GET: /Exam/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Exam/Delete/5
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
