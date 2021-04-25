using System;
using System.Collections.Generic;

namespace AnimalOOPExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism: IAnimal's methods has multiple forms for each subsclass
            // Each subclass is implementing its own version of IAnimal's methods         
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Fish("Shark"));
            animals.Add(new Mammal("Lion"));
            animals.Add(new Bird("Eagle"));

            foreach (IAnimal animal in animals)
            {
                animal.DoEat();
                animal.DoMove();
                animal.MakeSound();
            }
        }

    }
}
