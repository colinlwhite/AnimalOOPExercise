using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalOOPExercise
{
    abstract public class BaseAnimal : IAnimal
    {
        /// <summary>
        /// Encapsulation because only subclasses of BaseAnimal can access this property.
        /// Program.cs file doesn't need to know about how this class works internally
        /// </summary>
        protected string Name { get; set; }
        protected BaseAnimal(string name)
        {
            Name = name;
        }
        public void DoEat()
        {
            Console.WriteLine($"The {Name} is eating food.");
        }

        public abstract void DoMove();

        public abstract void MakeSound();

    }
}
