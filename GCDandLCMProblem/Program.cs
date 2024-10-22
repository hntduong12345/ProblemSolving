using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int count = 0;

        //Find GCD of b
        int gcdOfB = b[0];
        for (int i = 1; i < b.Count; i++)
        {
            gcdOfB = GCD(b[i], gcdOfB);

            if (gcdOfB == 1)
                break;
        }

        //Find LCD of a
        int lcmOfA = LCM(a);

        if (lcmOfA > b.Min()) return count;

        for (int i = 1; i * lcmOfA <= b.Min(); i++)
        {
            if (gcdOfB % (lcmOfA * i) == 0)
            {
                count++;
            }
        }

        return count;
    }

    //Find GCD
    public static int GCD(int a, int b)
    {
        if (a == 0) return b;

        return GCD(b % a, a);
    }

    //Find LCD
    public static int LCM(List<int> b)
    {
        return b.Aggregate((x, y) => x * y / GCD(x, y));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        Console.WriteLine(total);
    }
}
