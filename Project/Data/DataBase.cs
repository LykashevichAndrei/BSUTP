using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Entities;

namespace Data
{
    public class DataBase
    {
        private List<Student> _students=new List<Student>();
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Admin> _admins = new List<Admin>();
        public DataBase()
        {
            using (StreamReader file = File.OpenText(@"D:\\BSUTP\\Project\\Data\\Data\\Students.json"))
            {
                _students = JsonConvert.DeserializeObject<List<Student>>(file.ReadToEnd());
            }
            using (StreamReader file = File.OpenText(@"D:\\BSUTP\\Project\\Data\\Data\\Teachers.json"))
            {
                _teachers = JsonConvert.DeserializeObject<List<Teacher>>(file.ReadToEnd());
            }
            using (StreamReader file = File.OpenText(@"D:\\BSUTP\\Project\\Data\\Data\\Admins.json"))
            {
                _admins = JsonConvert.DeserializeObject<List<Admin>>(file.ReadToEnd());
            }

        }

        public List<Student> Students
        {
            get
            {
                return _students;
            }
        }
        public List<Admin> Admins
        {
            get
            {
                return _admins;
            }
        }
        public List<Teacher> Teachers
        {
            get
            {
                return _teachers;
            }
        }

        public List<Student> GetStudents(string faculty,int groupNumber)
        {
            List<Student> ActualStudents = _students.Where(n => n.Faculty == faculty && n.Group == groupNumber).ToList();
            return ActualStudents;
        }
    }
}
