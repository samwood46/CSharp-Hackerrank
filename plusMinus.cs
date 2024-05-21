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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        List<int> positive = new List<int>();
        List<int> zero = new List<int>();
        List<int> negative = new List<int>();

        double posAns = 0;
        double negAns = 0;
        double zeroAns = 0;

        int arrLength = arr.Count;
        for (int i = 0; i < arrLength; i++)
        {
            if (arr[i] > 0)
            {
                posAns = posAns + 1;
            }
            else if (arr[i] == 0)
            {
                zeroAns = zeroAns + 1;
            }
            else if (arr[i] < 0)
            {
                negAns = negAns + 1;
            }
        }

        posAns = posAns / arrLength;
        zeroAns = zeroAns / arrLength;
        negAns = negAns / arrLength;


        Console.WriteLine(posAns.ToString("n6"));
        Console.WriteLine(negAns.ToString("n6"));
        Console.WriteLine(zeroAns.ToString("n6"));



        }



    }


class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}