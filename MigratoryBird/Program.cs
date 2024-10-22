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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        Dictionary<int, int> birds = new Dictionary<int, int>();
        for (int i = 0; i < arr.Count; i++)
        {
            if (!birds.ContainsKey(arr[i]))
            {
                birds.Add(arr[i], 1);
            }
            else
            {
                birds[arr[i]]++;
            }
        }

        int result = 0, count = 0;
        foreach (int key in birds.Keys)
        {
            if (count <= birds[key])
            {
                if (count == birds[key])
                {
                    if (result > key) result = key;
                }
                else
                {
                    count = birds[key];
                    result = key;
                }
            }
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        Console.Write(result);
    }
}
