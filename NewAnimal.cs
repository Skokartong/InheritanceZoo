using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    // Class for creating a new animal
    class NewAnimal : Animal
    {
        public void NameNew()
        {
            Console.WriteLine("What's the animal's name?");
            Name = Console.ReadLine();
        }
        public void AgeNew()
        {
            Console.WriteLine("How old is the animal?");
            Age = int.Parse(Console.ReadLine());
        }

        public void SpeciesNew()
        {
            Console.WriteLine("What species is the animal?");
            Species = Console.ReadLine();
        }

        public void ColourNew()
        {
            Console.WriteLine("What colour does the animal have?");
            Colour = Console.ReadLine();
        }

        public void FoodNew()
        {
            Console.WriteLine("What food does the animal eat?");
            Food = Console.ReadLine();
        }
    }
}
