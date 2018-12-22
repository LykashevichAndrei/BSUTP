using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class Discipline
    {
        public int DisciplineId { get; set; }
        public string _Name { get; set; }
        public Teacher lecturer { get; set; } = null;
        public double firstMark;
        public double secondMark;
    }
}
