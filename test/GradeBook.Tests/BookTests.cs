using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange your test data, objects and values
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);


            // act perform method or calculation
            var result = book.GetStatistics();

            //assert something about the value
            Assert.Equal(85.6, result.Average, 1);  // the 1 checks precision to 1 decimal place
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        } 

        [Fact]
        public void CheckValidGrade()
        {
            // arrange your test data, objects and values
            var book = new Book("");
            book.AddGrade(105.0);
            book.AddGrade(80.0);



            // act perform method or calculation
            var result = book.GetStatistics();

            //assert something about the value
            Assert.Equal(80.0, result.Average, 1);  // the 1 checks precision to 1 decimal place

        }


    }
}
