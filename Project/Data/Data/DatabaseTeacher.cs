using System.Collections;
using System.Collections.Generic;
using Entities;
using SQLite;

namespace Data
{
    class DatabaseTeacher : IDatabase
    {
        private SQLiteConnection db = new SQLiteConnection("Teachers.db", true);

        public void Add<Teacher>(Teacher teacher)
        {
            try
            {
                db.Insert(teacher);
            }
            finally
            {
                db.Dispose();
            }
        }
        public void AddList<Teacher>(List<Teacher> teachers)
        {
            try
            {
                db.InsertAll(teachers);
            }
            finally
            {
                db.Dispose();
            }
        }
        public void Update<Teacher>(Teacher teacher)
        {
            try
            {
                db.Update(teacher);
            }
            finally
            {
                db.Dispose();
            }
        }
        public void Delete<Teacher>(Teacher teacher)
        {
            try
            {
                db.Delete<Teacher>(teacher);
            }
            finally
            {
                db.Dispose();
            }
        }

        public IList GetByFaculty(string faculty)
        {
            try
            {
                var selectedTeachers = db.Table<Teacher>().Where(n => n.Faculty == faculty);
                return (IList)selectedTeachers;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
