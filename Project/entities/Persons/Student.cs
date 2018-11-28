using System;
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
        private bool _inInBudget;
        private int _group;
        private double _averageBall;
        private double _scholarship;
        private List<int> marks;

        //public Student(string Name,string Password)
        //{
        //    Data.GetStudentWithLogin(Name);
        //}
        public int Group { get; set; }

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
