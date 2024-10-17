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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

class Result
{
    /*Problem:
    You are choreographing a circus show with various animals. For one act, you are given two kangaroos on a number line ready to jump in the positive direction (i.e, toward positive infinity).
    The first kangaroo starts at location x1 and moves at a rate of v1 meters per jump.
    The second kangaroo starts at location x2 and moves at a rate of v2 meters per jump.
    You have to figure out a way to get both kangaroos at the same location at the same time as part of the show.If it is possible, return YES, otherwise return NO.*/

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1: Kangaroo 1 start point
     *  2. INTEGER v1: Kangaroo 1 velocity (jump rate)
     *  3. INTEGER x2: Kangaroo 2 start point
     *  4. INTEGER v2: Kangaroo 2 velocity (jump rate)
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 - v2 == 0)
        {
            if (x2 - x1 == 0) return "YES";
            else return "NO";
        }

        var k = (Double)(x2 - x1) / (v1 - v2);

        if (k < 0) return "NO";

        //Check is k is integer or double(decimal)
        if (k % 1 == 0) return "YES";

        return "NO";
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
