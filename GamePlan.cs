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

public class Program
{
    public static double CalculateFinalSpeed(double initialSpeed, int[] inclinations)
    {
        double speed = initialSpeed;
        foreach (var inclination in inclinations)
        {
            if (inclination < 0)
            {
                speed += (inclination *-1);
            }
            else if (inclination > 0 )
            {
                speed -= inclination;
            }

            if (speed < 0)
            {
                speed = 0;
            }
        }
        return speed;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(CalculateFinalSpeed(60, new int[] { 0, 30, 0, -45, 0 }));
    }

}