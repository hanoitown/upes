using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPES.Core.Models;

namespace WebHost.Models
{
    public class DepartmentInputModel
    {
        public Department Department { get; set; }
        public SelectList Faculties { get; set; }
        public DepartmentInputModel(Department department, IEnumerable faculties)
        {
            Department = department;
            Faculties = new SelectList(faculties, "Id", "Name", department.FacultyId);
        }
    }
}