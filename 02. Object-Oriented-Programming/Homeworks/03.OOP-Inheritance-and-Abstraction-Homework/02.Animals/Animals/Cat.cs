using System;
using System.Runtime.InteropServices;

namespace _02.Animals.Animals
{
    class Cat : Animal, ISoundProducible
    {
        public Cat(string name, int age, Genders gender)
            : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("I say mayyy!");
        }
    }
}
