using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataBase
{
    public class SQLiteAdminsRepository : IRepository<Admin>
    {
        private bool disposed = false;
        
        public SQLiteAdminsRepository(StudentsContext db)
        {
            this.db = db;
        }

        public StudentsContext db { get; set; }

        public IEnumerable<Admin> GetList()
        {
            return db.Admins;
        }

        public Admin Get(int id)
        {
            return db.Admins.Find(id);
        }

        public void Create(Admin item)
        {
            db.Admins.Add(item);
        }

        public void Update(Admin item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var account = db.Admins.Find(id);
            if (account != null)
            {
                db.Admins.Remove(account);
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