using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleClass circle = new CircleClass();
            Console.WriteLine("Enter radius Value\n");
            circle.radius= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Diamter is "+circle.diameteFunction()+"\n Perimeter is "+ circle.perimeterFunction()+"\n area is :"+ circle.areaFunction());

            Console.ReadKey();
        }
    }
}
