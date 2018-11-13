using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2parasbajaniaP1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tution, registration, tax;
            Console.WriteLine("The student's age");
            string A = Console.ReadLine();
            int B = int.Parse(A);
            Console.WriteLine("Internatonal student enter yes or no");
            string C = Console.ReadLine();
            Console.WriteLine("Registration Semester(fall,summer or winter)");
            string D = Console.ReadLine();

            if (C == "not")
            {
                if (B <= 18)
                {
                    tution = 300 + (300 * 13 / 100);
                    Console.WriteLine("Base tution $" + tution);
                }
                else if(B<=49)
                {
                    tution = 500 + (500 * 13 / 100);
                    Console.WriteLine("Base tution $" + tution);
                }
                else if(B>=50)
                {
                    tution = 400 + (400 * 13 / 100);
                    Console.WriteLine("Base tution $"+ tution);
                }
            }
            else if (C == "yes")
            {
                if (B <= 18)
                {
                    tution = 400 + (400 * 13 / 100);
                    Console.WriteLine("Base tution Fee $" + tution);
                }
                else if (B <= 49)
                {
                    tution = 600 + (600 * 13 / 100);
                    Console.WriteLine("Base tution Fee $" + tution);
                }
                else if (B >= 50)
                {
                    tution = 500 + (500 * 13 / 100);
                    Console.WriteLine("Base tution Fee $" + tution);
                }
            }
            switch (D)
            {
                case "fall":
                    {
                        registration = 250 + (250 * 13 / 100);
                        Console.WriteLine("Registration Fee for fall semester $" + registration);
                        tax = 250 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "winter": 
                    {
                        registration = 220 + (220 * 13 / 100);
                        Console.WriteLine("Registration Fee for winter semester $" + registration);
                        tax = 220 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                case "summer":
                    {
                        registration = 150 + (150 * 13 / 100);
                        Console.WriteLine("Registration Fee for summer semester $" + registration);
                        tax = 150 * 13 / 100;
                        Console.WriteLine("HST $" + tax);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid semester");
                        break;
                    }
            }

        }   
    }
}
