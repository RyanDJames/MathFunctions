using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Formulas
{
    public class Program
    {
        static void Main(string[] args)
        {

             Program hemiV = new Program();

            Console.WriteLine("Welcome! I am the Geometry Guru. I will help you calculate!");
            Console.WriteLine("Let's find the area and circumference of a circle" +
                ". Please enter the radius: ");
            
            double radius = double.Parse(Console.ReadLine());
            double circumference = hemiV.Circumference(radius);
            double area = hemiV.AreaC(radius);
            
            
            string v = $"Area is:";


            Console.WriteLine("The Area of our circle is: {0}", area);
            Console.WriteLine("The Circumference of our circle is {0}", circumference);


            //End of first Equation======================================



            Console.Write("Please enter the radius of your hemisphere: ");
            double value = double.Parse(Console.ReadLine());
            double hemisphereV2 = hemiV.Hemisphere(value);
            Console.WriteLine($"The Volume of a hemisphere with the radius {value} is {hemisphereV2}");

            //End of second Equation======================================


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

            //End of third equation==============================================

             Program quadraticF = new Program();
            Console.WriteLine("Now we're going to solve a quadratic equation!");
            Console.WriteLine("First Lets get the value of A: ");
            double valueA=double.Parse(Console.ReadLine());
            Console.WriteLine("Now, let's get the value of B!: ");
            double valueB =double.Parse(Console.ReadLine());
            Console.WriteLine("And finally, give feed me some C!: ");
            double valueC =double.Parse(Console.ReadLine());

            double _X = hemiV.NegitiveQuadraticE(valueA, valueB, valueC);
            double x = hemiV.PositiveQuadraticE(valueA, valueB, valueC);

            Console.Write($"The first value of X is: {_X}");
            Console.Write($"The second value of X is: {x}");

            Console.WriteLine("Congratulations! Did I give you the answers you seek? I sure hope so!");
        }
        public double AreaC(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Circumference(double radius)
        {
            return  2 * Math.PI * radius;
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
            return Convert.ToInt32(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }




        public double NegitiveQuadraticE(double valueA, double valueB, double valueC)

        {
    
           return -valueB/ (2*valueA)
                - (Math.Sqrt(Math.Pow(valueB, 2) - 4 * valueA * valueC) / (2 * valueA));
            
        }

        public double PositiveQuadraticE(double valueA, double valueB, double valueC)
        {
            return -valueB/ (2*valueA) + (Math.Sqrt(Math.Pow(valueB, 2) - 4 * valueA * valueC) / (2 * valueA));
        }

    }
}
