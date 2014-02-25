using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPES.Core.Models
{
    public class ExamResult
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public virtual Enrollment Enrollment { get; set; }
        public virtual Exam Exam { get; set; }
    }
}
