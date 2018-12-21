using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataBase
{
    public class SQLiteStudentsRepository : IRepository<Student>
    {
        private bool disposed = false;
        private StudentsContext db;

        public SQLiteStudentsRepository(StudentsContext db)
        {
            this.db = db;
        }

        DbContext IRepository<Student>.DB { get => db; set => db = (StudentsContext)value; }

        public IEnumerable<Student> GetList()
        {
            return db.Students;
        }

        public Student Get(int id)
        {
            return db.Students.Find(id);
        }

        public void Create(Student item)
        {
            db.Students.Add(item);
        }

        public void Update(Student item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var account = db.Students.Find(id);
            if (account != null)
            {
                db.Students.Remove(account);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        
        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}