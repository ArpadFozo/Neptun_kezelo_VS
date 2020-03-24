using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak2
{
    class LinqResultConsole
    {

        public static void DisplayResult<T>(IEnumerable<T> result)
        {
            Type t = typeof(T);
            if (t == typeof(string) || t== typeof(int))
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                PropertyInfo[] props = t.GetProperties();
                foreach (var item in props)
                {
                    Console.Write(item.Name + "\t\t");
                }
                Console.WriteLine();
                foreach (var item in result)
                {
                    foreach (PropertyInfo prop in props)
                    {
                        var colorAtt = prop.GetCustomAttribute<ColoredPropertyAttribute>();

                        if(colorAtt != null)
                        {
                            ConsoleColor color = colorAtt.Color;
                            Console.ForegroundColor = color;
                            object value = prop.GetValue(item);
                            Console.Write(value.ToString() + "\t\t");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            object value = prop.GetValue(item);
                            Console.Write(value.ToString() + "\t\t");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
