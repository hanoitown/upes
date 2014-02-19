using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPES.Core.Models
{
    public class StudyResult
    {
        public virtual ICollection<Result> Results { get; set; }
        public virtual Subject Subject { get; set; }

    }
}
