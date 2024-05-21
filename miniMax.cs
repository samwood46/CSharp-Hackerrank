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
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        int total = arr.Sum();
        int mini = total;
        int maxi = 0;
        int arrLength = arr.Count();
        for (int i = 0; i <arrLength; i++)
        {
            if((total - arr[i]) < mini)
            {
                mini = (total - arr[i]);
            }
            if ((total - arr[i]) > maxi)
            {
                maxi = (total - arr[i]);
            }
        }
        Console.WriteLine(string.Format("{0} {1}", mini, maxi));
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
