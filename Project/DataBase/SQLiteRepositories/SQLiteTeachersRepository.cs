using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class SQLiteTeachersRepository : IRepository<Teacher>
    {
        private bool disposed = false;
        private TeachersContext db;

        public SQLiteTeachersRepository(TeachersContext db)
        {
            this.db = db;
        }

        public DbContext DB { get => db; set => db = (TeachersContext)value; }

        public IEnumerable<Teacher> GetList()
        {
            return db.Teachers;
        }

        public Teacher Get(int id)
        {
            return db.Teachers.Find(id);
        }

        public void Create(Teacher item)
        {
            db.Teachers.Add(item);
        }

        public void Update(Teacher item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var account = db.Teachers.Find(id);
            if (account != null)
            {
                db.Teachers.Remove(account);
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
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
