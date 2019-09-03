using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Gradebook 1.0]");

            // A list is more dynamic than an array.
            // They can still have their coords accessed with 
            // grades[x] or something similar
            List<double> grades = new List<double>();

            // This is for storing input double values.
            double input;
            // Stores highest grade.
            double highScore = 0.0;
            // Stores lowest grade.
            double lowScore = 100.0;
            // Stores average grade.
            double averageScore = 0.0;

            // Introductory spiel.
            Console.WriteLine("Enter the grade of each student.");
            Console.WriteLine("Each grade is a floating point number");
            Console.WriteLine("between 0 to 100, inclusive.");
            Console.WriteLine("Enter an invalid grade to see the results.");
            Console.Write("> ");

            // Parse input string as double and store in double input.
            input = Double.Parse(Console.ReadLine());

            // Loops to gather student grades.
            while(input >= 0 && input <= 100) 
            {
                Console.Write("> ");
                grades.Add(input);
                input = Double.Parse(Console.ReadLine());
            }

            // First time I've used a foreach. It's very handy!
            // Used this to add and compare grades for later output.
            foreach(double grade in grades) 
            {
                averageScore += grade;

                if(grade > highScore)
                {
                    highScore = grade;
                }
                else if(grade < lowScore) 
                {
                    lowScore = grade;
                }
            }

            // One final operation to divide the average score by the number
            // of elements in List grades.
            averageScore /= grades.Count;

            // Final output!
            Console.WriteLine($"Highest grade: {highScore}");
            Console.WriteLine($"Lowest grade: {lowScore}");
            Console.WriteLine($"Average grade: {averageScore}");

        }
    }
}
