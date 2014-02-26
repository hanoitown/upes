using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPES.Core.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool Gender { get; set; }
        public int IntakeId { get; set; }
        public Intake Intake { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
