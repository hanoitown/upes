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
        public int Credit { get; set; } // Số đơn vị học trình
        public int Hours { get; set; } // Thời gian

        public Faculty Faculty { get; set; } // Khoa
        public Department Department { get; set; } // Bộ môn giảng dạy        
        public virtual ICollection<Course> Courses { get; set; }

    }
}
