using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalOOPExercise
{
    public class Bird : BaseAnimal
    {
        public void BaseAnimal(string name) : base(name)
        {

        }
        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

        public override void DoMove()
        {
            throw new NotImplementedException();
        }
    }
}
