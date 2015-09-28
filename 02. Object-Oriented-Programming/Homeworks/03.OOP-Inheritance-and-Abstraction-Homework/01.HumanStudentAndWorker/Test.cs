using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.HumanStudentAndWorker
{
    class Test
    {
        static void Main()
        {
            IList<Student> students = new List<Student>
            {
                new Student("Petar", "Petrov", "20144567"),
                new Student("Georgi", "Danchev", "20141730"),
                new Student("Mihail", "Mishev", "20142589"),
                new Student("Ganka", "Georgieva", "20146547"),
                new Student("Sanya", "Tancheva", "20145285"),
                new Student("Ivan", "Ivanov", "20145687"),
                new Student("Dimitar", "Dimitrov", "20143698"),
                new Student("Damyan", "Damyanov", "20149634"),
                new Student("Mihail", "Petrov", "20147415"),
                new Student("Doncho", "Donchev", "20145612"),
            };

            IList<Worker> workers = new List<Worker>
            {
                new Worker("Kosta", "Kostadinov", 282m, 8f),
                new Worker("Sancho", "Ivanov", 382m, 6.5f),
                new Worker("Penka", "Kostadinova", 243m, 4.75f),
                new Worker("Dimitrichka", "Doynova", 152m, 2.75f),
                new Worker("Darina", "Stamatova", 182m, 5.5f),
                new Worker("Zlatomir", "Zlatev", 242m, 7.5f),
                new Worker("Petar", "Donchev", 482m, 6f),
                new Worker("Pencho", "Lalov", 578m, 9f),
                new Worker("Marko", "Totev", 439m, 8f),
                new Worker("Kostadin", "Kostadinov", 658m, 9f),
            };

            Console.WriteLine("Sorted Students:");
            var sortedStudents = students.OrderBy(st => st.FacultyNumber);
            foreach (var stud in sortedStudents)
            {
                Console.WriteLine(stud);
            }

            Console.WriteLine("\nSorted Workers: ");
            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour(5));
            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker + string.Format(", hourly rate: {0:N2}", worker.MoneyPerHour(5)));
            }

            Console.WriteLine("\nSorted Humans: ");
            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            var sortedHumans = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
