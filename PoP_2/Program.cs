using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoP_2
{
    class Program
    {
        //PRINCIPLES OF PROGRAMMING : HOMEWORK 12/10
        static void Main(string[] args)
        {
            //MeAfter10();
            //HelloName();
            //Sum();
            //Operations();
            //Multiplication();
            //Table();
            //Average();
            //Range();
            //Today();
            //Birth();
            //Axis();
        }
        static void MeAfter10()
        {
            int age = -1;
            string input;

            while(age == -1)
            {
                Console.Clear();
                Console.WriteLine("Please enter your age : ");
                input = Console.ReadLine();

                if (IsOnlyDigits(input) == true) age = Convert.ToInt32(input);
            }
            Console.WriteLine("In 10 years, you will be " + (age + 10) + " years old.");
            Console.ReadKey();
        }
        static bool IsOnlyDigits(string str)
        {
            bool state = true;

            if (str.Length == 0) state = false;
            if (str == null) state = false;

            foreach (char c in str)
            {
                if (c < '0' || c > '9') return false;
            }

            return state;
        }

        static void HelloName()
        {
            Console.Write("Please enter your name : ");

            string str = Console.ReadLine();

            Console.WriteLine("Hello \n" + str);
            Console.ReadKey();
        }

        static void Sum()
        {
            Console.Write("Please enter number A : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter number B : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of " + a + " and " + b + " is " + (a + b));
            Console.ReadKey();
        }

        static void Operations()
        {
            Console.WriteLine("-1 + 4*6 = " + ((-1 + 4 * 6)));
            Console.WriteLine("(35 + 5) % 7 = " + ((35 + 5) % 7));
            Console.WriteLine("14 + -4 * 6 / 11 = " + (14 + (-4) * 6 / 11));
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + (2 + 15 / 6 * 1 - 7 % 2));
            Console.ReadKey();
        }

        static void Multiplication()
        {
            Console.Write("Please enter number A : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter number B : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Please enter number C : ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Multiplication of " + a + ", " + b + " and " + c + " equals " + (a * b * c));
            Console.ReadKey();
        }

        static void Table()
        {
            Console.Write("Please enter a number : ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <=10; i++)
            {
                Console.WriteLine(i + " * " + n + " = " + (i * n));
            }
            Console.ReadKey();
        }

        static void Average()
        {
            Console.Write("Please enter number A : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter number B : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Please enter number C : ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Please enter number D : ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("The average of " + a + ", " + b + ", " + c + " and " + d + " is " + ((a + b + c + d) / 4));
            Console.ReadKey();
        }

        static void Range()
        {
            Console.Write("Please enter a number : ");
            int a = int.Parse(Console.ReadLine());

            if(a>= 100 && a <= 200)
            {
                Console.WriteLine(a + " is between 100 and 200");
            }
            else
            {
                Console.WriteLine(a + " is not between 100 and 200");
            }
            Console.ReadKey();
        }

        static void Today()
        {
            DateTime date = new DateTime();

            date = DateTime.Today;

            Console.WriteLine(" TODAY'S DATE | Day : " + date.Day + ", Month : " + date.Month + ", Year : " + date.Year);
            Console.ReadKey();
        }

        static void Birth()
        {
            Console.Write("Please enter your age : ");
            int age = int.Parse(Console.ReadLine());

            DateTime date = new DateTime();
            date = DateTime.Today;

            Console.WriteLine("You were born in " + (date.Year - age));
            Console.ReadKey();
        }

        static void Axis()
        {
            Console.Write("Please enter number x : ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Please enter number y : ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Please enter number z : ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("(x + y).z = " + x+y*z + " and x.y + y.z = " + x*y + y*z);
            Console.ReadKey();
        }
    }
}
