using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPES.Core.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; } // Môn
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
