﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPES.Core.Models
{
    /// <summary>
    /// Bộ môn
    /// </summary>
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int? FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Specialization> Specializations { get; set; }
    }
}
