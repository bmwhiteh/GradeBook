using System;
using System.Collections.Generic;

namespace GradeBook
{

    /*
        Exercise 4
        Goal = Create a new Class named "Book"
        Learn = How to create Classes in C#
        Code Used = class Book {}
    */
    class Book
    {

        /*
        Exercise 6
        Goal = Handle some instances of NullReferenceException errors by creating a constructor class
        Learn = Create constructor class
        Notes = constructor name can have same name as class
        Code Used =
        
        public Book()
        {
            grades = new List<double>();
        }
    */  
        public Book(string name)
        {
            grades = new List<double>();
            /*
                this is an implicit variable that you use to specify that you 
                want the acting object, so in this case, this.name is referencing 
                private string name on the left and the parameter name on the right.
            */
            this.name = name;
            
        }

    /*
        Exercise 5
        Goal = Create a new method to handle the line "book.AddGrade(89.1);" from Program.css
        Learn = How to create Classes in C#
        Code Used =
        
        public void AddGrade(double grade){
            grades.Add(grade);
           
        }
    */

    //instance method
        public void AddGrade(double grade){
            grades.Add(grade);
           
        }

        /*Exercise 10
            Use a method to complete Exercise 9
        */
        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var number in grades)
            {
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
        }



        /*
            Exercise 7
            Goal = Allow outside of Book class access to this initialization
            Learn = it's important to keep your code safe from outside harm
            Code Used = 
                public List<double> grades; allows calls outside of the Book class
                private List<double> grades; require calls to happen instead of Book class

        */
//instance fields
        private List<double> grades;
        private string name;

    }
    
}