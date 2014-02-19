using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPES.Core.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int Sequence { get; set; }
        public virtual Student Student { get; set; }
        public virtual Exam Exam { get; set; }
    }
}
