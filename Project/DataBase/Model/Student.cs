using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class Student
    {
        public int StudentId { get; set; }
        public string _Name { get; set; }
        public string _Surname { get; set; }
        public bool _Dormitory { get; set; }
        public double _AverageBall { get; set; }
        public double _Scolarship { get; set; }
        public List<int> Marks;
        public string _Faculty { get; set; }
        public bool _IsInABudget { get; set; }
        public bool _IsDebtor { get; set; } = false;
        public bool _IsInAacademyVacation { get; set; } = false;
    }
}
