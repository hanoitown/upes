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
    public class CourseController : BaseController
    {
        public CourseController(IStudentAdmin repo)
            : base(repo)
        {

        }
        //
        // GET: /Course/
        public ActionResult Index()
        {
            return View(_repo.Courses.All);
        }

        //
        // GET: /Course/Details/5
        public ActionResult Details(int id)
        {
            var item = _repo.Courses.All.FirstOrDefault(c => c.Id == id);

            return View();
        }

        //
        // GET: /Course/Create
        public ActionResult Create()
        {
            var subjects = _repo.Subjects.All;
            var faculties = _repo.Faculties.All;
            var course = new Course();

            var vm = new CourseInputModel(course, subjects, faculties);
            return View(vm);
        }

        //
        // POST: /Course/Create
        [HttpPost]
        public ActionResult Create(Course course)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _repo.Courses.Add(course);
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
        // GET: /Course/Edit/5
        public ActionResult Edit(int id)
        {
            var subjects = _repo.Subjects.All;
            var faculties = _repo.Faculties.All;
            var course = _repo.Courses.All.First(c => c.Id == id);
            var vm = new CourseInputModel(course, subjects, faculties);
            return View(vm);
        }

        //
        // POST: /Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var item = _repo.Courses.All.FirstOrDefault(c => c.Id == id);
                    item.Name = course.Name;
                    item.Code = course.Code;
                    item.Start = course.Start;
                    item.Credit = course.Credit;
                    item.FacultyId = course.FacultyId;
                    item.SubjectId = course.SubjectId;
                    _repo.SaveChanges();

                    return RedirectToAction("Index");
                }
                var subjects = _repo.Subjects.All;
                var faculties = _repo.Faculties.All;
                var vm = new CourseInputModel(course, subjects, faculties);
                return View(vm);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Course/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var item = _repo.Courses.All.FirstOrDefault(c => c.Id == id);
                _repo.Courses.Remove(item);
                _repo.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                throw new Exception("Error");
            }
        }

        //
        // POST: /Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var item = _repo.Courses.All.FirstOrDefault(c => c.Id == id);
                _repo.Courses.Remove(item);
                _repo.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                throw new Exception("Error");
            }
        }
    }
}
