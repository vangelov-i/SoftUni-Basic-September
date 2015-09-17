using System;

namespace P15AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Please enter your birth date in format dd/mm/yyy: ");
            DateTime bDay = DateTime.Parse(Console.ReadLine());
            int ageNow = (int)((DateTime.Now - bDay).TotalDays / 365.25); // 365.25 because once in every 4 years you have an year that is 366 days long
            int age10Years = ageNow + 10;
            Console.WriteLine("You are {0} years old. In 10 years you\'ll be {1}", ageNow, age10Years);
        }
    }
}
