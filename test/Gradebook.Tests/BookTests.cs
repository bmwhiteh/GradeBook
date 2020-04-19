using System;
using GradeBook;
using Xunit;

namespace Gradebook.Tests
{
    public class UnitTest1
    {
        /*Module 5 Part 4 - Minute 4:00 start
             Lesson: show how to create a unit test and see how dotnet test shows an error in the command prompt
            Code Used:
            [Fact]
                public void Test1()
                {

                    
                    var x = 5;
                    var y = 2;
                    var expected = 7;

                    var actual = x * y;

                    Assert.Equal(expected, actual);


                }
        */

        /*Module 5 Part 5 - Minute 4:00 Start
            Use command line to add a reference to the Book class 
            dotnet add reference ..\..\src\GradeBook\GradeBook.csproj
        */
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);
            
            //act v1 - use existing method
           // var result = book.ShowStatistics();

            //act v2 - further revise methods to compartementalize the code
            var result = book.GetStatistics();


            //assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
