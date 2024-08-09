using System;
using System.Data.Common;

namespace LEAPYEAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool isLeapyear=false;
            Console.WriteLine("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());

            bool isDivisibleby4 = year % 4 == 0;
            if(isDivisibleby4)
            {
                bool isDivisibleby100 = year % 100 == 0;
                if (isDivisibleby100)
                {
                    bool isDivisibleby400 = year % 400 == 0;
                    if (isDivisibleby400)
                    {
                        isLeapyear = true;
                    }
                }
                else
                {
                    isLeapyear = true;
                }
            }

            if (isLeapyear)
            {
                Console.WriteLine("{0} is a Leap Year",year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year",year);
            }

            
        }

    }
       
}
