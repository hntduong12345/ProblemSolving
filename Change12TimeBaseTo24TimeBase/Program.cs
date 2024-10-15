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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string[] splitStr = s.Split(':');
        string hour = splitStr[0];
        string minute = splitStr[1];
        string second = splitStr[2];

        string period = second.Substring(2);
        second = second.Substring(0, 2);

        if (period == "AM" && hour == "12")
        {
            hour = "00";
        }
        else if (period == "PM" && int.Parse(hour) < 12)
        {
            hour = $"{int.Parse(hour) + 12}";
        }

        return String.Format("{0}:{1}:{2}", hour, minute, second);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.timeConversion(s);
        Console.WriteLine(result);
    }
}
