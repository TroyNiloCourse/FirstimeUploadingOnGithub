using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
            // InitialName = Name;
        }
        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                Addgrade(90);
                break;
                case 'B':
                Addgrade(80);
                break;
                case 'C':
                Addgrade(70);
                break;
                default:
                Addgrade(0);
                break;
            }
        }
       
        public void Addgrade(double grade)  //void - not returning a value
        {
            if(grade <= 100 && grade >= 0)
            {
            grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
          public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average =  0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            
                for(var i = 0; i < grades.Count; i++)
                {
                result.Low = Math.Min(grades[i], result.Low );  
                result.High = Math.Max(grades[i], result.High);
                result.Average += grades[i];
                }
                 result.Average /= grades.Count; // or result = result / grades.count  
                 return result;

            // foreach(var grade in grades)
            // {
            //     result.Low = Math.Min(grade, result.Low );  
            //     result.High = Math.Max(grade, result.High);
            //     result.Average += grade;
            // }
            // result.Average /= grades.Count; // or result = result / grades.count  
            // return result;
        }
        // public void ChangeName (string name)
        // {
        //     Name = name;
        // }
        // public void ResetName()
        // {

        //     Name = InitialName;
        // }
        // private string InitialName;

      
        private List<double> grades;
        public string Name;

      
    }
}