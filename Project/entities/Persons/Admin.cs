using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Admin : Person
    {
        public static Admin GetSetUpAdmit()
        {
            Admin admin = new Admin();
            admin.Date = DateTime.Now;
            admin.Faculty = "RFiKT";
            admin.Name = "Vasilii";
            admin.Patronymic = "Vasilievich";
            admin.Sex = "male";
            admin.Surname = "Homich";
            return admin;
        }
    }
}
