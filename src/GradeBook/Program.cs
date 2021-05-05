﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {                 //Parameter name  args
        static void Main(string[] args) // This is Method
        { 

         
            //var numbers = new [] {41.3, 33.3, 22.1, 11 .1 };  // for each statements

            var book = new Book("Troy's Gradebook");  //creting new class

            while(true)
            {
                Console.WriteLine("Enter a grade or press 'q' to quit");
                var input = Console.ReadLine();
                    if(input == "q")
                    {
                        break;
                    }
                try{
                      var grade = double.Parse(input);
                      book.Addgrade(grade);
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("**");
                    }
            }
            
            var stats =  book.GetStatistics();

            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");  //:N1 is 1 number after the decimal
            Console.WriteLine($"The Grade letter is {stats.Letter}");

         
           
      //  double [] numbers = new double [3]{41.3,33.3,22.2};  --> syntax if you know the exact value of arrays
            // double [] numbers = new double [3];         // Array syntax and assigning values
            // numbers[0]= 41.3;  
            // numbers[1]= 33.3;
            // numbers[2]= 22.2;

            // var result = numbers[0];                    // adding multiple variables syntax
            // result += numbers[1];
            // result += numbers[2];

            // Console.WriteLine(result);                     

            

            // if(args.Length > 0){
            // Console.WriteLine($"Hello {args[0]} !");  //string Interpulation
            // }                                                       //This are statements
            // else{
            //     Console.WriteLine($"Hello");

            // // var x = 34.1;
            // // var y = 44.4;
            // // var result = x+y;                      Adding in C#

            // // Console.WriteLine(result);
            // }
        }
    }
}
