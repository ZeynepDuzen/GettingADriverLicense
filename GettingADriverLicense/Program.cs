using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingADriverLicense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Getting a Driver License ***

            //if the age is between 18 - 65 and education is high school or university,
            //a person can get a driver license,
            //otherwise a person can not get a driver license

            int age;
            string education;

            Console.WriteLine("Please enter your age : ");
            age = Convert.ToInt16(Console.ReadLine());

            if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Please enter your educaion status : < h/H (high school) - u/U (University)>");
                education = Console.ReadLine();

                if (education == "h" || education == "H" || education == "u" || education == "U")
                {
                    Console.WriteLine("Congratulations,you can get a driver license");
                }
                else
                {
                    Console.WriteLine("You can not get a driver license");
                    Console.WriteLine("Because of your education status is not high school or university");
                }
            }
            else
            {
                Console.WriteLine("You can not get a driver license");
                Console.WriteLine("Because of you are not between 18 - 65");
            }

            Console.Read();
        }
    }
}
