using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private Genders gender;

        protected Animal(string name, int age, Genders gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name", "Name can not be null or emprty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age can not be negative!");
                }
                this.age = value;
            }
        }

        public Genders Gender { get; set; }

        public virtual void ProduceSound()
        {
        }
    }
}
