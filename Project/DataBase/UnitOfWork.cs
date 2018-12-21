using System;
using System.Runtime.InteropServices.ComTypes;

namespace DataBase
{
    public class UnitOfWork : IDisposable
    {
        
        private bool disposed = false;
        private AdminsContext db = new AdminsContext();
        private IRepository<Admin> _admins;

        public IRepository<Admin> Accounts
        {
            get
            {
                if (_admins == null)
                {
                    _admins = new SQLiteAdminsRepository(db);
                }

                return _admins;
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
                this.disposed = true;
            }
        }
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}