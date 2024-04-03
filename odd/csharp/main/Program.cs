using System;
using System.Collections.Generic;

public class Odd
{
    public static int FindOdd(int[] arrNumber)
    {
        Dictionary<int, int> counter = new Dictionary<int, int>();

        foreach (int number in arrNumber)
        {
            if (!counter.ContainsKey(number))
            {
                counter.Add(number, 1);
            }
            else
            {
                counter[number]++;
            }
        }

        foreach (KeyValuePair<int, int> item in counter)
        {
            if (item.Value % 2 != 0)
            {
                return item.Key;
            }
        }

        return 0;
    }

    public static void Main(string[] args)
    {
        int[] input = [0, 1, 0, 1, 0];
        int result = FindOdd(input);
        Console.WriteLine(result);
    }
}