using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalOOPExercise
{
    public class Mammal : BaseAnimal
    {
        /// <summary>
        /// Implementing Inheritance because we're inheriting functionality from the base class, BaseAnimal
        /// We're inheriting the DoMove and MakeSound methods
        /// </summary>
        /// <param name="name"></param>
        public Mammal(string name) : base(name) { }
       
        public override void DoMove()
        {
            Console.WriteLine($"The {Name} is running!");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"The {Name} roars!");
        }
    }
}
