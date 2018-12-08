using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Data
{
    public class DatabaseOperations
    {
        public List<Student> GetStudentByName(string name, string surname)
        {
            return Database.GetStudents().Where(s => s.Name == name && s.Surname == surname).ToList();
        }
        public List<Student> GetStudentsByFacultyGroup(string faculty, int groupNumber)
        {
            return Database.GetStudents().Where(s => s.Faculty == faculty && s.Group == groupNumber).ToList();
        }
        public List<Teacher> GetTeacherByFaculty(string faculty)
        {
            return Database.GetTeachers().Where(s => s.Faculty == faculty).ToList();
        }
        public List<Discipline> GetDiscipline(string name)
        {
            return Database.GetDisciplines().Where(s => s.Name == name).ToList();
        }
    }
}
