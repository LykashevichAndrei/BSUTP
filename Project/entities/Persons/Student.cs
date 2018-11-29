﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student : Person
    {
        private bool _privileges;
        private string _status;
        private bool _liveInSocialBehavior;
        private string _specialty;
        private int _course;
        private bool _inBudget;
        private int _group;
        private double _averageBall;
        private double _scholarship;
        private List<int> marks;

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
                return _scholarship;
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
    }
}
