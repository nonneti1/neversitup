using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Smile
{
    public static int CountSmileyFace(string[] inputString)
    {
        Regex regex = new Regex(@"^[:;][-~]?[)D]$");
        int totalSmileCount = 0;

        foreach (string data in inputString)
        {
            if (regex.IsMatch(data))
            {
                totalSmileCount++;
            }
        }

        return totalSmileCount;
    }

    public static void Main(string[] args)
    {
        string[] input = { ";D", ":-(", ":-)", ";)" };
        int result = CountSmileyFace(input);
        Console.WriteLine(result);
    }
}