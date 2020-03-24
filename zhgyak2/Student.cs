using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zhgyak2
{
    class Student
    {
        [ColoredProperty(ConsoleColor.Cyan)]
        public string Name { get; set; }
        public string Course { get; set; }
        public int Mark { get; set; }
        public string Type { get; set; }

        public static List<Student> FromXml(string filename)
        {
            List<Student> students = new List<Student>();
            XDocument xdoc = XDocument.Load(filename);

            foreach (XElement item in xdoc.Descendants("student"))
            {
                Student temp = new Student()
                {
                    Name = item.Element("name").Value,
                    Course = item.Element("course").Value,
                    Mark = int.Parse(item.Element("mark").Value),
                    Type = item.Element("type").Value
                };
                students.Add(temp);
            }
            return students;
        } 

    }
}
