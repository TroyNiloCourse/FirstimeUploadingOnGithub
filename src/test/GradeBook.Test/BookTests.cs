using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            
            var book = new Book("");
            book.Addgrade(89.1);
            book.Addgrade(90.5);
            book.Addgrade(77.3);

            //act 
            var result =  book.GetStatistics();


            //assert
            Assert.Equal(85.6, result.Average,1);
            Assert.Equal(90.5 , result.High,1);
            Assert.Equal(77.3, result.Low,1);
            Assert.Equal(result.Letter, 'B');

        }
    }
}
