﻿using System;
public class Exercise2
{
    public static void Main()
    {
        string str; /* Declares a string of size 100 */
        int l = 0;

        Console.Write("\n\nFind the length of a string :\n");
        Console.Write("---------------------------------\n");
        Console.Write("Input the string : ");
        str = Console.ReadLine();

        foreach (char chr in str)
        {
            l += 1;

        }

        Console.Write("Length of the string is : {0}\n\n", l);
    }
}
/*

Find the length of a string :
---------------------------------
Input the string : a;lkjdflaksjflakjdflaksjdf
Length of the string is : 26

Press any key to continue . . .
*/
