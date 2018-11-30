using SQLite;
using System.Collections;
using Entities;

namespace Data
{
    public class DatabaseStudent : IDatabase
    {
        private SQLiteConnection db = new SQLiteConnection("Students.db", true);

        public void Add<Student>(Student student)
        {

        }
        public void AddList<List>(List students)
        {

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
                db.DeleteAll<Student>();
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
