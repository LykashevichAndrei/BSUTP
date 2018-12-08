using System;
using System.Collections.Generic;
using Entities;
using SQLite;

namespace Data
{
    public class Database
    {
        private static SQLiteConnection db;

        private Database(Type type)
        {
            db = new SQLiteConnection(type.ToString() + ".db", true);
        }
        private Database(string type)
        {
            db = new SQLiteConnection(type + ".db", true);
        }

        public static void Add<T>(T t)
        {
            new Database(t.GetType());
            try
            {
                db.Insert(t);
            }
            finally
            {
                db.Dispose();
            }
        }
        public static void Add<T>(List<T> l)
        {
            new Database(l[0].GetType());
            try
            {
                db.InsertAll(l);
            }
            finally
            {
                db.Dispose();
            }
        }
        public static void Update<T>(T t)
        {
            new Database(t.GetType());
            try
            {
                db.Update(t);
            }
            finally
            {
                db.Dispose();
            }
        }
        public static void Update<T>(IEnumerable<T> t)
        {
            new Database(t.GetType());
            try
            {
                db.UpdateAll(t);
            }
            finally
            {
                db.Dispose();
            }
        }
        public static void Delete<T>(T t)
        {
            new Database(t.GetType());
            try
            {
                db.Delete<T>(t);
            }
            finally
            {
                db.Dispose();
            }
        }
        /*public static void Clear<T>(T t)
        {
            new Database(t.GetType());
            try
            {
                db.DeleteAll<T>();
            }
            finally
            {
                db.Dispose();
            }
        }*/
        public static List<Student> GetStudents()
        {
            new Database("Student");
            try
            {
                return (List<Student>)(IList<Student>)db.Table<Student>();
            }
            finally
            {
                db.Dispose();
            }
        }
        public static List<Teacher> GetTeachers()
        {
            new Database("Teacher");
            try
            {
                return (List<Teacher>)(IList<Teacher>)db.Table<Teacher>();
            }
            finally
            {
                db.Dispose();
            }
        }
        public static List<Discipline> GetDisciplines()
        {
            new Database("Discipline");
            try
            {
                return (List<Discipline>)(IList<Discipline>)db.Table<Discipline>();
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
