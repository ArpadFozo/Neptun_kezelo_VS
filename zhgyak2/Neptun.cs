using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak2
{
    class Neptun
    {
        Model1 DataBase;
        List<Student> Students;
        public Neptun(Model1 database, List<Student> students)
        {
            this.DataBase = database;
            this.Students = students;
        }

        public void OpreAll()
        {
            var q = from x in Students
                    where x.Course == "opre"
                    select x;
            LinqResultConsole.DisplayResult(q);
        }
        public void OpreName()
        {
            var q = from x in Students
                    where x.Course == "opre"
                    select x.Name;
            LinqResultConsole.DisplayResult(q);
        }
        public void CoursesShort()
        {
            var q = from x in Students
                    group x by x.Course into g
                    select new
                    {
                        CourseName = g.Key,
                        CourseAvg = g.Average(t=>t.Mark)
                    };
            LinqResultConsole.DisplayResult(q);
        }
        public void CoursesLong()
        {
            var q = from x in Students
                    join y in DataBase.course on x.Course equals y.courseShortName
                    group x by y.courseLongName into g
                    select new
                    {
                        CourseName = g.Key,
                        CourseAvg = g.Average(t => t.Mark)
                    };
            LinqResultConsole.DisplayResult(q);
        }
        public void NamePlusCourses()
        {
            var q = from x in Students
                    join y in DataBase.course on x.Course equals y.courseShortName
                    select new
                    {
                        StudentName = x.Name,
                        CourseName = y.courseLongName
                    };
            LinqResultConsole.DisplayResult(q);
        }
    }
}
