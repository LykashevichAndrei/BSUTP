using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class Lists
    {
        public List<Student> students;
        public List<Teacher> teachers;
        public List<Admin> admins;
        public List<Discipline> disciplines;

        public Lists()
        {
            var sqlStudents = new SQLiteStudentsRepository(new StudentsContext());
            students = (List<Student>)sqlStudents.GetList();
            var sqlTeachers = new SQLiteTeachersRepository(new TeachersContext());
            teachers = (List<Teacher>)sqlTeachers.GetList();
            var sqlAdmins = new SQLiteAdminsRepository(new AdminsContext());
            admins = (List<Admin>)sqlAdmins.GetList();
            var sqlDisciplines = new SQLiteDisciplinesRepository(new DisciplinesContext());
            disciplines = (List<Discipline>)sqlDisciplines.GetList();
        }
    }
}
