﻿using System;

namespace _04UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main()
        {
            //Declare a character variable and assign it with 
            //the symbol that has Unicode code 42 (decimal) using 
            //the '\u00XX' syntax, and then print it. Hint: first,
            //use the Windows Calculator to find the hexadecimal representation of 42. 

            char symbol = '\u002A';
            Console.WriteLine(symbol);
        }
    }
}
