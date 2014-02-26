using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPES.Core.Models;

namespace UPES.EF
{
    public class Context : DbContext
    {
        public Context()
            : base("upes")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Intake> Intakes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("upes");
            modelBuilder.Entity<Exam>().HasRequired(x => x.Course).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Department>().HasRequired(x => x.Faculty).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Subject>().HasRequired(x => x.Department).WithMany().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Scope>().HasMany(x => x.AllowedClients).WithMany();
            //modelBuilder.Entity<StoredGrant>().HasMany(x => x.Scopes).WithMany();
            //modelBuilder.Entity<StoredGrant>().HasMany(x => x.ResourceOwner).WithRequired();
        }
    }
}
