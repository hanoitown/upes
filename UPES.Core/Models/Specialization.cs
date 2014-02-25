using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPES.Core.Models
{
    /// <summary>
    /// Chuyên sâu
    /// </summary>
    public class Specialization
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Intake> Intakes { get; set; } // Có nhiều lớp 
    }
}
