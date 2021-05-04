using System;
using Xunit;

namespace GradeBook.Test
{
    public class TypeTests
    {

      [Fact]
      public void StringBehavesLikesValueTypes()
      {
        string name = "Troy";
        name = MakeUpper(name);
        var upper = MakeUpper(name);

        Assert.Equal("TROY", name);
        Assert.Equal("TROY", upper);
      }

        private string MakeUpper(string parameter)
        {
          return parameter.ToUpper();
        }

        [Fact]
        public void Test1()
        {
          var x = GetInt();
          SetInt(ref x);

          Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpIsPassByRef()
        {
          var book1 = GetBook("Book 1");
          GetBookSetName(ref book1, "New Name");

          Assert.Equal(book1.Name , "New Name");
        }
         private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
          var book1 = GetBook("Book 1");
          GetBookSetName(ref book1, "New Name");

          Assert.Equal(book1.Name , "New Name");
        }
         private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
           
        }

        [Fact]
        public void CanSetFromReference()
        {
          var book1 = GetBook("Book 1");
          SetName(book1,"New Name");

          Assert.Equal(book1.Name , "New Name");
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDiffirentObjects()
        {
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");

        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
        Assert.NotSame(book1,book2);

        }
          [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
        var book1 = GetBook("Book 1");
        var book2 = book1;

        Assert.Same(book1,book2);
        Assert.True(Object.ReferenceEquals(book1,book2));

        }

        Book GetBook(string name)
        {
          return new Book(name);
        }
    }
}
