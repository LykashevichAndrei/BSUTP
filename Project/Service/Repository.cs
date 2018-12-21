﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace Service
{
    internal class Repository
    {
        public List<Admin> _admins;
        public List<Discipline> _disciplines;
        public List<Students> _students;
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
        public List<Disciplines> GetDisciplines() => _disciplines;
        public List<Students> GetStudents() => _students;
        public List<Teachers> GetTeachers() => _teachers;
    }
}
