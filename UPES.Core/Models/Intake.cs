using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPES.Core.Models
{
    /// <summary>
    /// Lớp, vd: Điền Kinh 45
    /// </summary>
    public class Intake
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public int? SpecializationId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Specialization Specialization { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
