namespace Lab6
{
    // Base class 'Animal'
    public class Animal
    {
        // Six properties that all animals of the base class share
        public int Age { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Colour { get; set; }
        public string Sound { get; set; }
        public string Food { get; set; }

        // Methods that all animals of the base class share
        public void MakeSound()
        {
            Console.WriteLine($"The {Species} says {Sound}");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping, shhh!");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating {Food} right now!");
        }
        public void Info()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Species: {Species}, Colour: {Colour}, Food preference: {Food}");
        }
    }

    // Sub class 'Tiger'
    public class Tiger : Animal
    {
        public Tiger()
        {
            Name = "Roger";
            Age = 13;
            Species = "Tiger";
            Colour = "Orange with black stripes";
            Sound = "rawrrr rawrr";
            Food = "a crocodile";
        }

        // ASCII-art tiger
        public void ShowTiger()
        {
            Console.WriteLine("                       __,,,,_\r\n          _ __..-;''`--/'/ /.',-`-.\r\n      (`/' ` |  \\ \\ \\\\ / / / / .-'/`,_\r\n     /'`\\ \\   |  \\ | \\| // // / -.,/_,'-,\r\n    /<7' ;  \\ \\  | ; ||/ /| | \\/    |`-/,/-.,_,/')\r\n   /  _.-, `,-\\,__|  _-| / \\ \\/|_/  |    '-/.;.\\'\r\n   `-`  f/ ;      / __/ \\__ `/ |__/ |\r\n        `-'      |  -| =|\\_  \\  |-' |\r\n              __/   /_..-' `  ),'  //\r\n          fL ((__.-'((___..-'' \\__.'");
        }
    }

    // Sub class 'Lion' that inherits from sub class 'Tiger'
    class Lion : Tiger
    {
        public Lion()
        {
            Name = "Lotta";
            Age = 8;
            Species = "Lion";
            Colour = "Orange";
            Sound = "RAWRRR";
            Food = "a deer";
        }

        // A unique method for sub class lion
        public void CuddleLion()
        {
            Console.WriteLine($"As you cuddle with {Name}, she says {Sound}!");
        }
    }

    // Sub class 'Cheetah' that inherits from sub class 'Tiger'
    class Cheetah : Tiger
    {
        public Cheetah()
        {
            Name = "Henke";
            Age = 5;
            Species = "Cheetah";
            Colour = "Beige with black spots";
            Sound = "roars";
            Food = "a monkey";
        }

        // A unique method for sub class cheetah
        public void FetchCheetah()
        {
            Console.WriteLine($"{Name} runs fast as you fetch the toy, you better catch up!");
            Console.WriteLine($"He {Sound} violently!");
        }
    }

    class Elephant : Animal
    {
        public Elephant()
        {
            Name = "Nils";
            Age = 50;
            Species = "Elephant";
            Colour = "Grey";
            Sound = "voff voff";
            Food = "a banana";
        }

        // ASCII-art elephant
        public void ShowElephant()
        {
            Console.WriteLine("                        ____\r\n                   .---'-    \\\r\n      .-----------/           \\\r\n     /           (         ^  |   __\r\n&   (             \\        O  /  / .'\r\n'._/(              '-'  (.   (_.' /\r\n     \\                    \\     ./\r\n      |    |       |    |/ '._.'\r\n       )   @).____\\|  @ |\r\n   .  /    /       (    | mrf\r\n  \\|, '_:::\\  . ..  '_:::\\ ..\\).");
        }
    }

    class Giraffe : Animal
    {
        public Giraffe()
        {
            Name = "Greta";
            Age = 5;
            Species = "Giraffe";
            Colour = "Orange with brown spots";
            Sound = "moo moo";
            Food = "from a tree";
        }

        // ASCII-art giraffe
        public void ShowGiraffe()
        {
            Console.WriteLine("\r\n                     .c.\r\n                   .d$$e$.\r\n                .e$P\"   ^*%\r\n             .e$P\"\r\n           z$$$\"\r\n        z$$$$$F\r\n     .d$$$$$$$F\r\n  .d$$$$$$$$$$F\r\n.3$$$$$$$$$$$$F\r\n  $$$$$\" \"\"$*$\"\r\n   P $\"    $ $\r\n  d d\"     $ $\r\n  $ *      $ $\r\n   ) '     $ $\r\n    % '    $ $\r\n     % \"   $ $\r\n      - )  * *\r\n");
        }
    }

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