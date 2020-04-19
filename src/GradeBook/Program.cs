using System;
using System.Collections.Generic;

namespace GradeBook
{

    

    class Program
    {
        static void Main(string[] args)
        {

            /*
                Exercise 1:
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

            /*
                Exercise 2.1: 
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

            /*
                Exercise 2.2: 
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

            /*  Exercise 3:
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
            
            

         /*
            Exercise 5
            Goal = Create a new method to handle the line "book.AddGrade(89.1);" from Program.css
            Learn = How to call created methods
            Code Used =
            var book = new Book();
            book.AddGrade(89.1);

            Book book2 = new Book();
            book2.AddGrade(90.1);
        */   
            

        /*
            Exercise 8
            Goal = use Program class
            Learn = this would cause an infinite loop
            Code Used = 

            var p = new Program();
             Program.Main(args);

        */
        
        /*
            Exercise 9
            Goal = Calculate High, Low, and Average grades
            Learn = Compare values and output high, low, average
            Code Used = 
        
            var book = new Book("Bailey's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var number in grades)
            {
                
                
                //    Option 1: highGrade = number;
                //    if(number > highGrade){}
                
                
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;

            //My guess
            Console.WriteLine($"Highest: {highGrade}, Lowest: {lowGrade}, Average: {result}");
            

            //Exercise Answer
            Console.WriteLine($"The lowest grade is {lowGrade:N1}.");
            Console.WriteLine($"The highest grade is {highGrade:N1}.");
            Console.WriteLine($"The average grade is {result:N1}.");
*/

        /*
            Exercise 10
            Goal = use a method to do Exercise 9
            Learn = 
            Code Used = 
        
        var book = new Book("Bailey's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();

            Console.WriteLine($"Hello {args[0]}!");
        */

        /*Module 5 Part 6 - Minute 9:00
        */
        var book = new Book("Bailey's Grade Book");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.5);
        
        var stats = book.GetStatistics();
        Console.WriteLine($"The lowest grade is {stats.Low:N1}.");
        Console.WriteLine($"The highest grade is {stats.High:N1}.");
        Console.WriteLine($"The average grade is {stats.Average:N1}.");
 
       
        }
    }
}