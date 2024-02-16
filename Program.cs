using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Phil's GradeBook");
            book1.AddGrade(89.1);
            book1.AddGrade(90.5);
            book1.AddGrade(77.5);

            var stats = book1.GetStatistics();

            Console.WriteLine($"The average grade: {stats.Average:N1}");
            Console.WriteLine($"The highest grade: {stats.High:N1}");
            Console.WriteLine($"The lowest grade: {stats.Low:N1}");
        }         
    }
}
