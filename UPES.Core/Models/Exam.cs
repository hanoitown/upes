using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPES.Core.Models
{
    public class Exam
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime When { get; set; }
        public string Where { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
