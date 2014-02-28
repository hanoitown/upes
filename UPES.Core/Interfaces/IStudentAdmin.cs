using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPES.Core.Models;

namespace UPES.Core.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> All { get; }
        void Add(T item);
        void Remove(T item);
    }

    public interface IStudentAdmin
    {
        IRepository<Course> Courses { get; }
        IRepository<Subject> Subjects { get; }
        IRepository<Department> Departments { get; }
        IRepository<Faculty> Faculties { get; }
        IRepository<Exam> Exams { get; }
        IRepository<Specialization> Specializations { get; }
        IRepository<Intake> Intakes { get; }
        IRepository<Enrollment> Enrollments { get; }
        IRepository<Student> Students { get; }
        void SaveChanges();
    }
}
