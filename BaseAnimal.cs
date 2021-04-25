using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalOOPExercise
{
    abstract public class BaseAnimal : IAnimal
    {
        /// <summary>
        /// Encapsulation because only child classes can access this
        /// Program.cs doesn't need to know about how this class works internally
        /// </summary>
        protected string Name { get; set; }
        protected BaseAnimal(string name)
        {
            Name = name;
        }
        public void DoEat()
        {
            Console.WriteLine(Name + " is eating");
        }

        public abstract void DoMove();

        public abstract void MakeSound();

    }
}
