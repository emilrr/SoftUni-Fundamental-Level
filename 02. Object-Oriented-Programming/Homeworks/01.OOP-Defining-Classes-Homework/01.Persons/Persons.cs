using System;
using System.Collections.Generic;

namespace _01.Persons
{
    public class Persons
    {
        public static void Main()
        {
            List<Person> people = new List<Person>()
            {
                new Person("Ivan",28),
                new Person("Hristo", 20,"hristov@gmail.com"),
                new Person("Petar",18),
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

}
