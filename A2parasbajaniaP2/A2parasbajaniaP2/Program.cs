using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2parasbajaniaP2
{
    class Program
    {      static double sphere(double r, double p)
        {
            double sphere = 4 / 3 * p * r * r * r;
            return sphere;
        }
        static double cylinder(double r,double h, double p)
        {
            double cylinder = p * r * r * h;
            return cylinder;
        }
        static int rectangular(int l, int b,int h)
        {
            int rectangular =  l * b * h;
            return rectangular;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1:Sphere");
            Console.WriteLine("2:Cylinder");
            Console.WriteLine("3:Rectangular Prism");
            string Q = Console.ReadLine();
            int W = int.Parse(Q);
            if (W == 1)
            {
                Console.WriteLine("Enter the value of radius");
                string a = Console.ReadLine();
                double b = double.Parse(a);
                double result;
                result = sphere(3.14, b);
                Console.WriteLine("Volume of shpere is" + result);
            }
            else if (W == 2)
            {
                Console.WriteLine("Enter the value of radius");
                string a = Console.ReadLine();
                double b = double.Parse(a);
                Console.WriteLine("Enter the value of height");
                string c = Console.ReadLine();
                double d = double.Parse(c);
                double result;
                result = cylinder(3.14,b,d);
                Console.WriteLine("Volume of shpere is" + result);
            }
            else if (W == 3)
            {
                Console.WriteLine("Enter the lenght of rectangle");
                string a = Console.ReadLine();
                int b = int.Parse(a);
                Console.WriteLine("Enter the breadth of rectangle");
                string c = Console.ReadLine();
                int d = int.Parse(c);
                Console.WriteLine("Enter the height of rectangle");
                string e = Console.ReadLine();
                int f = int.Parse(e);
                int result;
                result = rectangular(f, b, d);
                Console.WriteLine("Volume of shpere is" + result);
            }
        }
    }
}
