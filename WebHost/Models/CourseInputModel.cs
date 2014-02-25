using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPES.Core.Models;

namespace WebHost.Models
{
    public class CourseInputModel
    {
        public Course Course { get; set; }
        public SelectList Subjects { get; set; }
        public SelectList Faculties { get; set; }

        public CourseInputModel(Course course, IEnumerable subjects, IEnumerable faculties)
        {
            Course = course;
            Subjects = new SelectList(subjects, "Id", "Name", course.SubjectId);
            Faculties = new SelectList(faculties, "Id", "Name", course.FacultyId);
        }
    }
}