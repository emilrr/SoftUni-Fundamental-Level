using System;

namespace _02.Animals.Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Genders.Female)
        {
        }
    }
}
