using System;

namespace _02.Animals.Animals
{
    class Dog : Animal,ISoundProducible
    {
        public Dog(string name, int age, Genders gender)
            : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("I say bau!");
        }
    }
}
