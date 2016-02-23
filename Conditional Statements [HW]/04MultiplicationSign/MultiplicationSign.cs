﻿using System;

//Write a program that shows the sign (+, - or 0) of the product 
//of three real numbers, without calculating it. Use a sequence 
//of if operators. Examples:

//a	        b	    c	    result
//5	        2	    2	    +
//-2	    -2	    1	    +
//-2	    4	    3	    -
//0	        -2.5	4	    0
//-1	    -0.5	-5.1	-

namespace _04MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            int signedCounter = 0;
            if (a < 0)
            {
                signedCounter++;
            }
            if (b < 0)
            {
                signedCounter++;
            }
            if (c < 0)
            {
                signedCounter++;
            }

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(0);
            }
            else if (signedCounter % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }

        }
    }
}
