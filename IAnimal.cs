using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalOOPExercise
{
    /// <summary>
    /// Abstraction is the process of hiding implementation details and showing only essential features of the object.
    /// It's not focused on implementation, but designing classes and Interfaces
    /// An Interface accomplishes that by telling what the class can do but without implementation details.
    /// </summary>
    interface IAnimal
    {
        void DoMove();
        void DoEat();
        void MakeSound();
    }
}
