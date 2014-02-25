using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPES.Core.Models;

namespace WebHost.Models
{
    public class ExamInputModel
    {
        public Exam Exam { get; set; }
        public SelectList Courses { get; set; }

        public ExamInputModel(Exam exam, IEnumerable courses)
        {
            Exam = exam;
            Courses = new SelectList(courses, "Id", "Name", exam.CourseId);
        }
    }
}