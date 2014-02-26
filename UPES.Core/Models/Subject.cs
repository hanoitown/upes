using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPES.Core.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } // Financial statistic
        public string Code { get; set; } // FS1/FS2
        public string Description { get; set; } // Lý thuyết, thực hành
        public bool IsTheory { get; set; }
        public int BaseCredit { get; set; } // Số đơn vị học trình
        public int? DepartmentId { get; set; }
        public Department Department { get; set; } // Bộ môn giảng dạy        
        public virtual ICollection<Course> Courses { get; set; }

    }
}
