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
        }

        public void Addgrade(double grade)  //void - not returning a value
        {
            grades.Add(grade);
        }
          public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average =  0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;


            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low );  
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            result.Average /= grades.Count; // or result = result / grades.count  
            return result;
        }

      
        private List<double> grades;
        public string Name;

      
    }
}