using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace Server
{
    internal static class Repository
    {
        private static Lists BD = new Lists();
        private static List<Admin> _admins = BD.admins;
        private static List<Discipline> _disciplines = BD.disciplines;
        private static List<Student> _students = BD.students;
        private static List<Teacher> _teachers = BD.teachers;

        public static List<Admin> GetAdmins() => _admins;
        public static List<Discipline> GetDisciplines() => _disciplines;
        public static List<Student> GetStudents() => _students;
        public static List<Teacher> GetTeachers() => _teachers;
        public static List<string> Faculties = new List<string>();
        public static List<string> GetFaculties()
        {
            Faculties.Add("RFIKT");
            Faculties.Add("FPM");
            Faculties.Add("FSK");
            Faculties.Add("IB");
            return Faculties;
        }
    }
}
