using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using _02.Animals.Animals;

namespace _02.Animals
{
    class Test
    {
        private static void Main()
        {
            IList<Animal> animals = new List<Animal>
            {
                new Cat("Maca",2, Genders.Female),
                new Cat("Kotio", 4, Genders.Male),
                new Dog("Balkan", 1, Genders.Male),
                new Dog("Sharo", 6, Genders.Male),
                new Frog("Tinka", 4, Genders.Female),
                new Frog("Gruncho", 7, Genders.Male),
                new Kitten("Mariika", 2),
                new Tomcat("Gancho", 2)
            };

            var groupAnimals = from animal in animals
                               group animal by (animal is Cat) ? typeof(Cat) : animal.GetType()
                                   into g
                                   select new { GroupName = g.Key, AverageAge = g.ToList().Average(a => a.Age) };
            foreach (var animal in groupAnimals)
            {
                Console.WriteLine("{0} - average age: {1:N2}", animal.GroupName.Name, animal.AverageAge);
            }
            Console.WriteLine();

            Animal rex = new Dog("Rex", 10, Genders.Male);
            Animal gosho = new Cat("Gosho", 5, Genders.Male);
            Animal tina = new Frog("Tina", 4, Genders.Female);

            rex.ProduceSound();
            gosho.ProduceSound();
            tina.ProduceSound();
        }

    }
}


