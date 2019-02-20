using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Welcome! I am the Geometry Guru. I will help you calculate!");
            Console.Write("Let's find the area and circumference of a circle.");
            double radius = 4.0 ;
                
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * 4;
            Console.Write("Area");
            Console.Write(area);
            
            Console.ReadLine();

        }
    }
}
