using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Person
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _sex;
        private DateTime _dateofBirth;
        private string _faculty;

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
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }
            set
            {
                _patronymic = value;
            }
        }
        public string Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }
        public string Faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                _faculty = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return _dateofBirth;
            }
            set
            {
                _dateofBirth = value;
            }
        }

    }
}
