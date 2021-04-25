using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalOOPExercise
{
    public class Fish : BaseAnimal
    {
        public Fish(string name) : base(name) { }

        public override void DoMove()
        {
            Console.WriteLine($"{Name} is swimming!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The {Name} is drumming underwater.");
        }
    }
}
