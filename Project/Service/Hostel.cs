using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Hostel
    {
        private int _numberOfSeats=100;
     
        DatabaseOperations dataBase = new DatabaseOperations();
        public void SettleStudent()
        {
            int temp = _numberOfSeats;
            List<Student> students = dataBase.Students;
            var priviligiesStudents = students.Where(n => n.Privileges == true);
            foreach (Student student in priviligiesStudents)
            {
                student.LiveInSocialBehavior = true;
            }
            temp -= priviligiesStudents.Count();
            var otherStudents = students.Except(priviligiesStudents).OrderBy(n => n.AverageBall);
            foreach(Student student in otherStudents)
            {
                if (temp != 0)
                    student.LiveInSocialBehavior = true;
                else
                    break;
            }
        }
    }
}
