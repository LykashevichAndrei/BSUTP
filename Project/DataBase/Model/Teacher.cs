using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string _Name { get; set; }
        public string _Surname { get; set; }
        public List<Discipline> _disciplinesTaught;
    }
}
