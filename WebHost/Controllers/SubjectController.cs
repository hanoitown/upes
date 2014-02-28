using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPES.Core.Interfaces;
using PagedList;

namespace WebHost.Controllers
{
    public class SubjectController : BaseController
    {
        public SubjectController(IStudentAdmin repo)
            : base(repo)
        {

        }

        //
        // GET: /Subject/
        //public ActionResult Index()
        //{
        //    return View(_repo.Subjects.All);
        //}

        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "";
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var subjects = _repo.Subjects.All;

            if (!String.IsNullOrEmpty(searchString))
                subjects = subjects.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper()));


            switch (sortOrder)
            {
                case "Name_desc":
                    subjects = subjects.OrderByDescending(s => s.Name);
                    break;
                default:
                    subjects = subjects.OrderBy(s => s.Name);
                    break;
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(subjects.ToPagedList(pageNumber, pageSize));

        }

        //
        // GET: /Subject/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Subject/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Subject/Create
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
        // GET: /Subject/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Subject/Edit/5
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
        // GET: /Subject/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Subject/Delete/5
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
