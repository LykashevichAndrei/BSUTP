using Entities;
using SQLite;
using System.Collections;
using System.Collections.Generic;

namespace Data
{
    class DatabaseDiscipline : IDatabase
    {
        private SQLiteConnection db = new SQLiteConnection("Disciplines.db", true);

        public void Add<Discipline>(Discipline discipline)
        {
            try
            {
                db.Insert(discipline);
            }
            finally
            {
                db.Dispose();
            }
        }
        public void AddList<Discipline>(List<Discipline> disciplines)
        {
            try
            {
                db.InsertAll(disciplines);
            }
            finally
            {
                db.Dispose();
            }
        }
        public void Update<Discipline>(Discipline discipline)
        {
            try
            {
                db.Update(discipline);
            }
            finally
            {
                db.Dispose();
            }
        }
        public void Delete<Discipline>(Discipline discipline)
        {
            try
            {
                db.Delete<Discipline>(discipline);
            }
            finally
            {
                db.Dispose();
            }
        }

        public IList GetByName(string name)
        {
            try
            {
                var selectedDisciplines = db.Table<Discipline>().Where(n => n.Name == name);
                return (IList)selectedDisciplines;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
