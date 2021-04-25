using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalOOPExercise
{
    public class Mammal : BaseAnimal
    {
        public Mammal(string name) : base(name)
        {

        }
        public override void DoMove()
        {
            Console.WriteLine($"The {Name} is running!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The {Name} makes whatever sound that a {Name} makes!");
        }
    }
}
