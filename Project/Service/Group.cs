using Data;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Group
    {
        List<Student> students;
        DataBase data;
        public Group(string faculty,int group)
        {
            data = new DataBase();
            students = data.GetStudents(faculty, group);
        }
    }
}
