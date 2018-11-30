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
        DatabaseOperations data;
        public Group(string faculty,int group)
        {
            data = new DatabaseOperations();
            students = data.GetStudentsByFacultyGroup(faculty, group);
        }
    }
}
