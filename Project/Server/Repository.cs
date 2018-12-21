using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace Server
{
    internal class Repository
    {
        public List<Admin> _admins;
        public List<Discipline> _disciplines;
        public List<Student> _students;
        public List<Teacher> _teachers;
        public Repository()
        {
            Lists BD = new Lists();
            _admins = BD.admins;
            _disciplines = BD.disciplines;
            _students = BD.students;
            _teachers = BD.teachers;
        }
        public List<Admin> GetAdmins() => _admins;
        public List<Discipline> GetDisciplines() => _disciplines;
        public List<Student> GetStudents() => _students;
        public List<Teacher> GetTeachers() => _teachers;
    }
}
