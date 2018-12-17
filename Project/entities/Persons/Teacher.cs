using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Teacher : Person
    {
        public static Teacher GetSetUpAdmit()
        {
            Teacher teacher = new Teacher();
            teacher.Date = DateTime.Now;
            teacher.Faculty = "RFiKT";
            teacher.Name = "Vasilii";
            teacher.Patronymic = "Vasilievich";
            teacher.Sex = "male";
            teacher.Surname = "Homich";
            return teacher;
        }
    }
}
