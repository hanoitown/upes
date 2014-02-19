using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPES.Core.Models
{
    /// <summary>
    /// Khoa
    /// </summary>
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
