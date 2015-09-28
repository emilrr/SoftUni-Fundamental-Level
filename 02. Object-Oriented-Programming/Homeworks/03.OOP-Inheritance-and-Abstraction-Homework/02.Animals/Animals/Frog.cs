using System;

namespace _02.Animals.Animals
{
    class Frog : Animal, ISoundProducible
    {
        public Frog(string name, int age, Genders gender)
            : base(name, age, gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("I say krya-krya!");
        }
    }
}
