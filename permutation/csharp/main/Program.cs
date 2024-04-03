using System;
using System.Collections.Generic;

public class Permutations
{
    public static void Swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    public static List<string> FindPermutations(string str, int n = 0, char[] arr = null)
    {
        if (n == 0)
        {
            n = str.Length;
            arr = str.ToCharArray();
        }

        List<string> result = new List<string>();

        if (n == 1)
        {
            result.Add(new string(arr));
            return result;
        }

        for (int i = 0; i < n; i++)
        {
            result.AddRange(FindPermutations(str, n - 1, arr));
            if (n % 2 == 0)
            {
                Swap(arr, i, n - 1);
            }
            else
            {
                Swap(arr, 0, n - 1);
            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        string inputString = "abc";
        List<string> permutations = FindPermutations(inputString);
        Console.WriteLine("Permutations:");
        foreach (string permutation in permutations)
        {
            Console.WriteLine(permutation);
        }
    }
}