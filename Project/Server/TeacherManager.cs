using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    class TeacherManager
    {
        public List<Teacher> _teachers = Repository.GetTeachers();

        public List<Student> GetStydentsWithCoursWorkFor(Teacher teacher) => teacher._students;
        
    }
}
