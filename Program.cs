using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        Console.WriteLine("Accept number:");
        var num1 = int.Parse(Console.ReadLine());
        if (num1 == 0 || num1 == 1)
        {
            Console.WriteLine("no");
            Console.ReadLine();
        }

        if (CheckPrime(num1))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }

    private static bool CheckPrime(int num1)
    {
        for (int a = 2; a <= num1 / 2; a++)
        {
            if (num1 % a == 0)
            {
                return false;
            }
        }
        return true;
    }
}