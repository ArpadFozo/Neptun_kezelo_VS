using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhgyak2
{
    class ColoredPropertyAttribute : Attribute
    {
        public ConsoleColor Color { get; private set; }

        public ColoredPropertyAttribute(ConsoleColor color)
        {
            this.Color = color;
        }

    }
}
