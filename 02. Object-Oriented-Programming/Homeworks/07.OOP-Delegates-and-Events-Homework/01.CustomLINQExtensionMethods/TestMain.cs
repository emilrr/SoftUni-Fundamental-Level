using System;
using System.Collections.Generic;

namespace _01.CustomLINQExtensionMethods
{
    class TestMain
    {
        static void Main()
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var filterCollection = num.WhereNot(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", filterCollection));

            var students = new List<Student>
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5)
            };

            Console.WriteLine(students.Max(student => student.Grade));
        }
    }
}
