using System;
using System.Collections.Generic;

namespace AnimalOOPExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
