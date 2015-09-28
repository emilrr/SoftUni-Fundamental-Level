using System;
using System.Collections.Generic;
using System.Linq;

internal class SortStudents
{
    private static void Main()
    {
        var students = new List<Student>
        {
            new Student("Dimitar", "Dimitrov", 20, 1, "0897777777", "dimitar@gmail.com", new List<int> {5, 3, 4, 6}, 2),
            new Student("Georgi", "Ivanov", 22, 2, "0897553344", "georgi@abv.bg", new List<int> {5, 4, 5, 6}, 1),
            new Student("Ivan", "Georgiev", 20, 3, "0888664425", "ivanov@@g,ail.com", new List<int> {6, 6, 5, 6}, 1),
            new Student("Dimitrinka", "Ivanova", 22, 4, "02-12356", "ivanova@gmail.com", new List<int> {5, 5, 5, 5}, 2),
            new Student("Katya", "Georgieva", 18, 5, "03022221", "jdjdjdj@ght.gh", new List<int> {4, 5, 6, 4}, 1),
            new Student("Mishael", "Tonchev",18,6,"0878919299","dffdf@abv.bg",new List<int> {4, 2, 2, 6},2),
        };

        Console.WriteLine("Using Lambda:");

        
        var sortStudentsLambda =
            students.OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));
        foreach (var st in sortStudentsLambda)
        {
            Console.WriteLine(st);
        }

        Console.WriteLine();
        Console.WriteLine("\nLINQ Query:");
        Console.WriteLine();

        var sortStudentsLINQ =
            from st in students
            orderby st.FirstName descending, st.LastName descending
            select st;

        foreach (var st in sortStudentsLINQ)
        {
            Console.WriteLine(st.FirstName + " " + st.LastName);
        }
    }

}