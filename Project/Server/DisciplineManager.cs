using DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    class DisciplineManager
    {
        public List<Discipline> _disciplines = Repository.GetDisciplines();

        public void SetLecturesFor(Discipline discipline)
        {
            foreach (Teacher el in Repository.GetTeachers())
            {
                if(el._disciplinesTaught.Contains(discipline))
                {
                    discipline.lecturer = el;
                    break;
                }
            }
        }
        public void SetCoefs(Discipline disc, double fmark)
        {
            if (fmark < 1)
            {
                disc.firstMark = fmark;
                disc.secondMark = (1 - fmark);
            }
            else
                throw new ArgumentOutOfRangeException();
        }
    }
}
