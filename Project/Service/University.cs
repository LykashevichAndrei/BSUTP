//using Data;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class University
    {
        private readonly int _basicscholarship = 100;
        private readonly int _numberOfBudgetStydents = 50;

        public void SetStudentsFormOfStudy()
        {
            int temp = _numberOfBudgetStydents;
            List<Student> students = new List<Student>();
                //Database.GetStudents();
            students.OrderBy(n => n.AverageBall);
            foreach (Student student in students)
            {
                if (student.Status == "continue education" && temp !=0)
                {
                    student.InBudget = true;
                    temp--;
                    continue;
                }
                student.InBudget = false;
            }
        }
       /* public void SetStudentsScolarship()
        {
            List<Student> students = Database.GetStudents();
            foreach (Student student in students)
            {
                double coefficient = 0;
                if (student.AverageBall > 4 && student.AverageBall < 6)
                    coefficient = 1;
                if (student.AverageBall > 6 && student.AverageBall < 8.5)
                    coefficient = 1.4;
                if (student.AverageBall > 8.5 && student.AverageBall < 10)
                    coefficient = 1.8;
                if (student.InBudget==true)
                {
                    student.Scholarship = _basicscholarship * coefficient;
                }
            }*/
           // Database.Update(students);
        //}
    }
}

