using System;
using GradeBook;
using Xunit;

namespace Gradebook.Tests
{

    /* Module 6 Part 10 - Minute 0:00 Start
    */
    public class Person
    {

    }

    public struct Point
    {

    }


    public class TypeTests
    {
        
        /*Module 6 Part 4 - Minute 4:00 Start
            Create a new test case to test the types
        */
        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        /*Module 6 Part 5 - Minute 4:00 Start
            Create a new test case to test the types
        */
        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        /*Module 6 Part 6 - Minute 1:00 Start
            Create a new test case to test the types and test SetName
        */
        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        /*Module 6 Part 7 - Minute 2:00 Start
            Create a new test case to test the types and test SetName
            ref signifies passed by reference
        */
        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        /*Module 6 Part 8 - Minute 0:30 Start
            Create a new test case to test the types and test SetName
            ref signifies passed by reference
        */
        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(x);

            Assert.Equal(42, x);
        }

        /*Module 6 Part 11 - Minute 0:30 Start
            Create a new test case to test the types
        */
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Bailey";
            var upper = MakeUpperCase(name);

            Assert.Equal("Bailey", name);
            Assert.Equal("BAILEY", upper);

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        /*Create a new book instance and set it to Name*/
        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
            book.Name = name;

        }

        private void SetInt(int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }
    
            private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }

    }

}
