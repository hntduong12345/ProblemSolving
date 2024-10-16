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
     * Complete the 'countApplesAndOranges' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER s            : House's start point
     *  2. INTEGER t            : House's end point
     *  3. INTEGER a            : Apple tree location
     *  4. INTEGER b            : Orange tree location
     *  5. INTEGER_ARRAY apples : Apple fruits location
     *  6. INTEGER_ARRAY oranges: Orange fruits location
     */

    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int appleCount = 0, orangeCount = 0;

        apples.ForEach(x =>
        {
            if (x + a >= s && x + a <= t) { appleCount++; }
        });

        oranges.ForEach(x =>
        {
            if (x + b >= s && x + b <= t) { orangeCount++; }
        });

        Console.WriteLine(appleCount + "-" + orangeCount);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int s = Convert.ToInt32(firstMultipleInput[0]);
        int t = Convert.ToInt32(firstMultipleInput[1]);
        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int a = Convert.ToInt32(secondMultipleInput[0]);
        int b = Convert.ToInt32(secondMultipleInput[1]);
        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int m = Convert.ToInt32(thirdMultipleInput[0]);
        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();
        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
