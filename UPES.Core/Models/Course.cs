﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPES.Core.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public int Credit { get; set; } // Số đơn vị học trình
        public virtual Subject Subject { get; set; } // Môn
        public virtual Faculty Faculty { get; set; } // Khoa          
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Course()
        {
            Exams = new HashSet<Exam>();
            Students = new List<Student>();
        }
    }
}
