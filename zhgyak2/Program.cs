using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.FromXml(@"students.xml");
            Model1 data = new Model1();
            Neptun nep = new Neptun(data, students);
            nep.OpreAll();
            nep.OpreName();
            nep.CoursesShort();
            nep.CoursesLong();
            nep.NamePlusCourses();
            Console.ReadLine();
        }
    }
}
