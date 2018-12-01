using SQLite;
using System.Collections;
using Entities;
using System.Collections.Generic;

namespace Data
{
    public class DatabaseStudent : IDatabase
    {
        private SQLiteConnection db = new SQLiteConnection("Students.db", true);

        public void Add<Student>(Student student)
        {
            try
            {
                db.Insert(student);
            }
            finally
            {
                db.Dispose();
            }
        }
        public void AddList<Student>(List<Student> students)
        {
            try
            {
                db.InsertAll(students);
            }
            finally
            {
                db.Dispose();
            }
        }
        public void Update<Student>(Student student)
        {
            try
            {
                db.Update(student);
            }
            finally
            {
                db.Dispose();
            }
        }
        public void Delete<Student>(Student student)
        {
            try
            {
                db.Delete<Student>(student);
            }
            finally
            {
                db.Dispose();
            }
        }

        public IList Get(string faculty, int groupNumber)
        {
            try
            {
                var selectedStudents = db.Table<Student>().Where(n => n.Faculty == faculty && n.Group == groupNumber);
                return (IList)selectedStudents;
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
