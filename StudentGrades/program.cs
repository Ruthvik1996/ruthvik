﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGrades;

internal class Program
{
    public static void Main(string[] args)
    {
        var gradeCalculator = new GradeCalculator();

        Console.Write("Enter the percentage:");
        var percentage = Convert.ToInt32(Console.ReadLine());

        var grade = gradeCalculator.GetGradeByPercentage(percentage);

        Console.WriteLine($"Student Grade : {grade}");
    }
}
