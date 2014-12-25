using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleConsoleApp
{
    class CircleClass
    {
        public double radius;
        const double pi = 3.1416;
        public double diameteFunction()
        {

            return (2 * radius);

        }

        public double perimeterFunction()
        {
            return (2 * pi * radius);
        }

        public double areaFunction()
        {
            return (pi * radius * radius);
        }
    }
}
