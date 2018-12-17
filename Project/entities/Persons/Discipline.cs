using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Discipline
    {
        private string _name;
        private double _firstMark;
        private double _secondMark;
        private List<Student> _students;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Discipline() { }

        public Discipline(List<Student> students, double a, double b)
        {
            this._firstMark = a;
            this._secondMark = b;
            this._students = students;
        }

        public void SetMark(string name, string secondName, string patronymic, int mark)
        {
            var actualStudent = _students.First(n => n.Name == name && n.Patronymic == patronymic && n.Surname == secondName);
            actualStudent.AddMark(mark);
        }
        public void PrintStatement()
        {

        }
    }
}
