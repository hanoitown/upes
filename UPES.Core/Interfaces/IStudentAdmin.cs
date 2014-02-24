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

        void SaveChanges();
    }
}
