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
}