using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.SQLiteRepositories
{
    class SQLiteDisciplinesRepository : IRepository<Discipline>
    {
        private bool disposed = false;
        private DisciplinesContext db;

        public SQLiteDisciplinesRepository(DisciplinesContext db)
        {
            this.db = db;
        }

        public DbContext DB { get => db; set => db = (DisciplinesContext)value; }

        public IEnumerable<Discipline> GetList()
        {
            return db.Disciplines;
        }

        public Discipline Get(int id)
        {
            return db.Disciplines.Find(id);
        }

        public void Create(Discipline item)
        {
            db.Disciplines.Add(item);
        }

        public void Update(Discipline item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var account = db.Disciplines.Find(id);
            if (account != null)
            {
                db.Disciplines.Remove(account);
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
