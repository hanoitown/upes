using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPES.Core.Interfaces;
using UPES.Core.Models;

namespace UPES.EF
{
    public class Repository<T> : IRepository<T>
    where T : class
    {
        DbSet<T> dbSet;

        public Repository(DbSet<T> dbSet)
        {
            this.dbSet = dbSet;
        }

        IQueryable<T> IRepository<T>.All
        {
            get { return this.dbSet; }
        }

        public void Add(T item)
        {
            dbSet.Add(item);
        }

        public void Remove(T item)
        {
            dbSet.Remove(item);
        }
    }

    public class StudentAdmin : IStudentAdmin
    {
        Context db;

        public StudentAdmin(Context _db)
        {
            db = _db;
        }
        public IRepository<Course> Courses
        {
            get { return new Repository<Course>(db.Courses); }
        }

        public void SaveChanges()
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
