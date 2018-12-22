using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    class StudentManager
    {
        public List<Student> _students = Repository.GetStudents();
        private static int _baseScolarship = 100;
        public void SetStudentScolarship()
        {
            foreach(Student student in _students)
            {
                student._Scolarship = _baseScolarship * GetCoef(student);
            }
        }
        private double GetCoef(Student student)
        {
            if (student._AverageBall > 4 && student._AverageBall < 6)
                return 1;
            if (student._AverageBall > 6 && student._AverageBall < 8)
                return 1.4;
            if (student._AverageBall > 8 && student._AverageBall < 10)
                return 1.6;
            else
                return 0;
        }
        public void SetAverageBall()
        {
            foreach(Student el in _students)
            {
                if(el.Marks.Count==5)
                {
                    el._AverageBall = el.Marks.Average();
                }
            }
        }
        public void GetAcadem(Student student)
        {
            student._IsInAacademyVacation = true;
        }

        public void AddMark(Student student, int mark)
        {
            if (student._IsInAacademyVacation == false)
                student.Marks.Add(mark);
            if (mark < 4)
                student._IsDebtor = true;
        }
        public void SetStudentsStatus()
        {
            int budgetPlaces = 50;
            var sortedStudents = _students.OrderBy(n => n._AverageBall).ToArray();
            for(int i=0;i<budgetPlaces;i++)
            {
                sortedStudents[i]._IsInABudget = true;
            }
            int temp = sortedStudents.Count() - budgetPlaces;
            if(temp>=0)
            {
                for(int i=budgetPlaces;i< sortedStudents.Count();i++)
                {
                    sortedStudents[i]._IsInABudget = false;
                }
            }

        }
    }
}
