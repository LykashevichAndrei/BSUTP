using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
