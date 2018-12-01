using System.Collections.Generic;
using Entities;

namespace Data
{
    public class DatabaseOperations
    {
        private List<Student> _students = new List<Student>();
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Admin> _admins = new List<Admin>();

        public DatabaseOperations()
        {

        }

        public List<Student> Students
        {
            get
            {
                return _students;
            }
        }
        public List<Admin> Admins
        {
            get
            {
                return _admins;
            }
        }
        public List<Teacher> Teachers
        {
            get
            {
                return _teachers;
            }
        }

        public List<Student> GetStudentsByFacultyGroup(string faculty, int groupNumber)
        {
            DatabaseStudent dBstudent = new DatabaseStudent();
            var ActualStudents = (List<Student>)dBstudent.Get(faculty, groupNumber);
            return ActualStudents;
        }

        public void AddStudent(Student student)
        {
            DatabaseStudent db = new DatabaseStudent();
            db.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            DatabaseTeacher db = new DatabaseTeacher();
            db.Add(teacher);
        }
    }
}
