using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class Student : Person
    {
        private bool _privileges;
        private string _status;
        private bool _liveInSocialBehavior;
        private string _speciality;
        private int _course;
        private bool _inBudget;
        private int _group;
        private double _averageBall;
        private double _scholarship;
        private static int _basicscholarship = 100;
        private List<int> marks;

        public void AddMark(int mark)
        {
                marks.Add(mark);   
        }
        public List<int> GetMarks
        {
            get
            {
                return marks;
            }
        }

        public bool LiveInSocialBehavior
        {
            get
            {
                return _liveInSocialBehavior;
            }
            set
            {
                _liveInSocialBehavior = value;
            }
        }
        public bool Privileges
        {
            get
            {
                return _privileges;
            }
            set
            {
                _privileges = value;
            }
        }
        public double Scholarship
        {
            get
            {
                double coefficient = 0;
                if (AverageBall > 4 && AverageBall < 6)
                    coefficient = 1;
                if (AverageBall > 6 && AverageBall < 8.5)
                    coefficient = 1.4;
                if (AverageBall > 8.5 && AverageBall < 10)
                    coefficient = 1.8;
                if (InBudget == true)
                {
                    _scholarship = _basicscholarship * coefficient;
                }
                return Scholarship;
            }
            set
            {
                _scholarship = value;
            }
        }
        public bool InBudget
        {
            get
            {
                return _inBudget;
            }
            set
            {
                _inBudget = value;
            }
        }

        public int Group
        {
            get
            {
                return _group;
            }

            set
            {
                _group = value;
            }
        }
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status=value;
            }
        }

        public double AverageBall
        {
            get
            {
                return _averageBall;
            }
            set
            {
                _averageBall = value;
            }
        }

        public string Speciality { get; set; }
        public int Year { get; set; }

        public void SetMark(int mark)
        {
            if (mark > 10||mark<0)
                throw new ArgumentOutOfRangeException();
            if (mark < 4)
                this._status = "debtor";
            marks.Add(mark);
            if (marks.Count == 5 && this._status!= "debtor")
               this._averageBall = marks.Average();
        }
        public static Student GetSetupStudent()
        {
            Student student = new Student();
            student.AverageBall = 8;
            student.Date = DateTime.Now;
            student.Faculty = "RFiKT";
            student.Group = 6;
            student.InBudget = true;
            student.LiveInSocialBehavior = false;
            student.Name = "Andrei";
            student.Patronymic = "Evginievich";
            student.Sex = "male";
            student.Surname = "Lukashevich";
            student.Privileges = false;
            student._scholarship = 100;
            student._course = 3;
            return student;
        }
    }
}
