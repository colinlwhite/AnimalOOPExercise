using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalOOPExercise
{
    public class Bird : BaseAnimal
    {
        /// <summary>
        /// The base keyword is used to access members of the base class from within a derived class
        /// I'm assuming we're specifying which base-class constructor should be called when creating 
        /// instances of the derived class.
        /// </summary>
        /// <param name="name"></param>
        public Bird(string name) : base(name)
        {

        }
        
        public override void MakeSound()
        {
            // Console.WriteLine("The" + Name + "is doing whatever " + Name + "'s do");
            Console.WriteLine($"The {Name} is making whatever sound that {Name} make");
        }

        public override void DoMove()
        {
            Console.WriteLine($"The {Name} is flying!");
        }
    }
}
