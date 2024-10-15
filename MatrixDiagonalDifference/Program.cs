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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int result = 0;
        int leftDia = 0, rightDia = 0;

        for (int i = 0; i < arr.Count(); i++)
        {
            leftDia += arr[i][i];
            rightDia += arr[i][arr[i].Count()-i-1];
        }

        Console.WriteLine(leftDia);
        Console.WriteLine(rightDia);

        Console.WriteLine(Math.Abs(leftDia - rightDia));
        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>
        {
            new List<int>{1,2,11},
            new List<int>{4,9,6},
            new List<int>{-8,8,-3},
        };

        int result = Result.diagonalDifference(arr);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
