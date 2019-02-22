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
            Console.WriteLine("Welcome! I am the Geometry Guru. I will help you calculate!");
            Console.WriteLine("Let's find the area and circumference of a circle" +
                " with a radius of 4");
            double radius = 4.0;

            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * 4.0;
            string v = $"Area is:";


            Console.WriteLine("The Area of our circle is: {0}", area);
            Console.WriteLine("The Circumference of our circle is {0}", circumference);


            Program hemiV = new Program();



            Console.Write("Please enter the radius of your hemisphere: ");
            double value = double.Parse(Console.ReadLine());
            double hemisphereV2 = hemiV.Hemisphere(value);
            Console.WriteLine($"The Volume of a hemisphere with the radius {value} is {hemisphereV2}");


            Console.WriteLine("Now we're going to calculate the area of a triangle!");

            Console.Write("Please input the Value of side A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please input the value of side B:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Please input the value of side C:");
            int c = int.Parse(Console.ReadLine());

            int p = hemiV.Heron(a, b, c);
            int areaTri = hemiV.Heron2(a, b, c, p);

            Console.WriteLine($"The Triangle's area is {areaTri}");

            Program quadraticF = new Program();
            Console.WriteLine("Now we're going to solve a quadratic equation!");



        }

        public double Hemisphere(double value)
        {

            return (4.0 / 3) * Math.PI * Math.Pow(value, 3) / 2;


        }

        public int Heron(int a, int b, int c)
        {

            return (a + b + c) / 2;

        }

        public int Heron2(int a, int b, int c, int p)
        { 
           return Convert.ToInt32(Math.Sqrt(p* (p-a) * (p - b) * (p - c)));
            }
        
        public double 
        
        

    }
}
