using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Exercise 1:
                Goal = Output "Hello [Name]" if a Name is provided in the command line, Output "Hello Nobody!"
                Lesson learned = using the parameter args allows you to use 0 or more input from the command line in the body of your program
                Code Used = 
                if(args.Length > 0)
                {
                    Console.WriteLine($"Hello {args[0]}!");
                }
                else
                {
                    Console.WriteLine("Hello Nobody!");
                }
            */

            /*Exercise 2.1: 
                Goal = Add numbers together to produce a result
                Lesson = Learn how to add multiple numbers together as an initialized var[] containing 3 numbers
                Notes = using var here allows us to define the array as new[] which will allow the compiler to decide that it is an array of doubles
                Code Used = 
                var numbers = new[] {12.7, 10.3, 6.11};
                var result = 0.0;
                result += numbers[0];
                result += numbers[1];
                result += numbers[2];

                Console.WriteLine($"Result = {result}");
            */

            /*Exercise 2.2: 
                Goal = Add numbers together to produce a result
                Lesson = Learn how to add multiple numbers together as an initialized var[] containing 3 numbers using a foreach loop
                Code Used = 
                var numbers = new[] {12.7, 10.3, 6.11};
                var result = 0.0;

                foreach (var number in numbers)
                {
                    result += number;
                }
                Console.WriteLine($"Result = {result}");
            */

            /*Exercise 3:
                Goal = Add Numbers together and output the average
                Lesson = learn to initialize namespaces (System.Collections.Generic) and use a list to add numbers to a collection, sum the numbers, and determine the average
                Notes = .Add() will allow you to add a value of the required data type to the specified LIst
                Code Used = 
                    List<double> grades = new List<double>();
                    var result = 0.0;
                    
                    grades.Add(56.1);

                    foreach(var number in grades)
                    {
                        result += number;
                    }

                    // get the average of the entered grades
                    result /= grades.Count;
                    Console.WriteLine($"The average grade is {result}");
            */
            




            


        }
    }
}
