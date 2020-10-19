using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5();
        }
        static void Task1()
        {
            Console.WriteLine("TRIANGLE");

            Console.Write("Please enter side A : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Please enter side B : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Please enter side C : ");
            int c = int.Parse(Console.ReadLine());

            if (a == b && a == c) Console.WriteLine("All the sides are equal");
            else
            {
                if (a == b) Console.WriteLine("Two sides are equal : A and B");
                if (a == c) Console.WriteLine("Two sides are equal : A and C");
                if (b == c) Console.WriteLine("Two sides are equal : B and C");
            }
            Console.ReadKey();
        }

        static void Task2()
        {
            int sum = 0;
            int count = 0;

            int n;

            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Please enter number " + i + " : ");
                n = int.Parse(Console.ReadLine());

                if (n >= 10 && n <= 20)
                {
                    sum += n;
                    count++;
                }
            }
            Console.WriteLine("Numbers between 10 and 20 = " + count + ", sum is " + sum);
            Console.ReadKey();
        }

        static void Task3()
        {
            Console.Write("Please enter you height : ");
            int h = int.Parse(Console.ReadLine());

            if (h >= 190) Console.WriteLine("You should try basketball");
            if (h < 190 && h >= 175) Console.WriteLine("You should try Athletics");
            if (h < 175) Console.WriteLine("You should try horse riding");

            Console.ReadKey();
        }

        static void Task4()
        {
            Console.Write("Please enter the number of the day : ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Please enter the hour of today : ");
            int hour = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(1, 1, day, hour, 0, 0);

            Console.WriteLine(PhraseGenerator(date));

            Console.ReadKey();
        }
        static string PhraseGenerator(DateTime date)
        {


            string greetings = "morning";
            if (date.Hour > 12) greetings = "evening";

            string dayStr = "";
            switch (date.Day)
            {
                case 1:
                    {
                        dayStr = "Monday";
                        break;
                    }
                case 2:
                    {
                        dayStr = "Tuesday";
                        break;
                    }
                case 3:
                    {
                        dayStr = "Wednesday";
                        break;
                    }
                case 4:
                    {
                        dayStr = "Thursday";
                        break;
                    }
                case 5:
                    {
                        dayStr = "Friday";
                        break;
                    }
                case 6:
                    {
                        dayStr = "Saturday";
                        break;
                    }
                case 7:
                    {
                        dayStr = "Sunday";
                        break;
                    }
                default:
                    {
                        dayStr = "ERROR";
                        break;
                    }
            }

            string endPhrase = "here !";

            if (date.Day != 6 && date.Day != 7)
            {
                endPhrase = "coming in " + (6 - date.Day) + " days !";
            }

            string s = "Good " + greetings + ", it is lovely " + dayStr + " today. Weekend is " + endPhrase;

            return s;
        }

        static void Task5()
        {
            bool check = false;
            string firstName = "";
            string lastName = "";
            int intYear = 0;
            int intMonth = 0;
            int intDay = 0;

            string id = "";
            string yearID = "";
            string ffID = "";
            string ssID = "";
            string nnnnID = "";

            DateTime todayDate = new DateTime();
            todayDate = DateTime.Now;

            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your first name : ");
                firstName = Console.ReadLine();
                if (firstName.Length > 100) Console.WriteLine("Error : limit is 100 char");
                else
                {
                    check = true;
                }
            }

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your last name : ");
                lastName = Console.ReadLine();
                if (lastName.Length > 100) Console.WriteLine("Error : limit is 100 char");
                else
                {
                    check = true;
                }
            }

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your year of birth : ");
                string year = Console.ReadLine();

                if (IsOnlyDigits(year) == false)
                {
                    Console.WriteLine("Error : please enter digits only");
                }
                else
                {
                    intYear = int.Parse(year);
                    if (todayDate.Year - intYear > 100)
                    {
                        Console.WriteLine("Error : wrong input : input is " + year + ", and date is " + todayDate.Year);
                    }
                    else
                    {
                        check = true;
                    }
                }
            }

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your month of birth : ");
                string month = Console.ReadLine();
                if (IsOnlyDigits(month) == false) Console.WriteLine("Error : please enter digits only");
                else
                {
                    check = true;
                    intMonth = int.Parse(month);
                }
            }

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your day of birth : ");
                string day = Console.ReadLine();
                if (IsOnlyDigits(day) == false) Console.WriteLine("Error : please enter digits only");
                else
                {
                    check = true;
                    intDay = int.Parse(day);
                }
            }
            DateTime birth = new DateTime(intYear, intMonth, intDay);

            check = false;
            while (check == false)
            {
                Console.Clear();
                Console.Write("Please enter your student number : ");
                id = Console.ReadLine();
                if (IsOnlyDigits(id) == false || id.Length != 12) Console.WriteLine("Error : please enter digits only");

                else
                {                   
                    check = true;

                    if (id[4] != '0') check = false;
                    if (id[6] != '0') check = false;
                    if (IsOnlyDigitsTo5(id[7]) == false) check = false;

                    if (check == true)
                    {
                        for (int i = 0; i <= 11; i++)
                        {
                            if (i <= 3)
                            {
                                yearID += id[i];
                            }
                            if (i == 4 || i == 5)
                            {
                                ffID += id[i];
                            }
                            if (i == 6 || i == 7)
                            {
                                ssID += id[i];
                            }
                            if (i > 7)
                            {
                                nnnnID += id[i];
                            }
                        }                    
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("# PERSONNAL DATA #");
            Console.WriteLine("First name is " + firstName);
            Console.WriteLine("Last name is " + lastName);
            Console.WriteLine("Date of birth is " + birth.Day+ "/" + birth.Month + "/" + birth.Year);


            Console.WriteLine("Student number is " + id + " with year = " + yearID + ", faculty code = " + ffID + ", specialty code = " + ssID + ", specialty = " + nnnnID);
            Console.ReadKey();
        }

        static bool IsOnlyDigits(string n)
        {
            foreach(char c in n)
            {
                if (c < '0' || c > '9') return false;
            }
            return true;
        }
        static bool IsOnlyDigitsTo5(char n)
        {
            bool check = true;
            if (n < '0' || n > '5') check = false;

            return check;
        }
    }
}
