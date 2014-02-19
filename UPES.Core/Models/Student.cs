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
        public Specialization Specialization { get; set; }
        public Intake Intake { get; set; }
        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<Course> Taking { get; set; }
        public virtual ICollection<StudyResult> StudyResults { get; set; }


    }
}
