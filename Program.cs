using System;

namespace Lab6
{
    class Program
    {
        //Main-method
        public static void Main(string[] args)
        {
            bool visit = true;

            //6 objects created representing animals that are part of the base class 'Animal'
            Giraffe giraffe = new Giraffe();
            Tiger tiger = new Tiger();
            Cheetah cheetah = new Cheetah();
            Lion lion = new Lion();
            Elephant elephant = new Elephant();
            NewAnimal newanimal = new NewAnimal();

            Console.WriteLine("Welcome to the zoo! What do you want to do (1-9)? ");
            Console.WriteLine();
            Console.WriteLine("1. Hear the tiger make a sound\n2. Hear the elephant make a sound");
            Console.WriteLine("3. Hear the giraffe make a sound\n4. Make the animals go sleeping");
            Console.WriteLine("5.Feed the animals \n6. Play fetch with the cheetah");
            Console.WriteLine("7. Cuddle with the lion \n8. Add an animal to the zoo");
            Console.WriteLine("9. See all current animals at the zoo");

            string reply = Console.ReadLine();

            //While-loop and switch-statements to allow the user to choose what to do while at the zoo
            while (visit)
            {
                switch (reply)
                {
                    case "1":
                        tiger.MakeSound();
                        tiger.ShowTiger();
                        break;

                    case "2":
                        elephant.MakeSound();
                        elephant.ShowElephant();
                        break;

                    case "3":
                        giraffe.MakeSound();
                        giraffe.ShowGiraffe();
                        break;

                    case "4":
                        tiger.Sleep();
                        elephant.Sleep();
                        giraffe.Sleep();
                        lion.Sleep();
                        cheetah.Sleep();
                        break;

                    case "5":
                        elephant.Eat();
                        tiger.Eat();
                        giraffe.Eat();
                        cheetah.Eat();
                        lion.Eat();
                        break;

                    case "6":
                        cheetah.FetchCheetah();
                        break;

                    case "7":
                        lion.CuddleLion();
                        break;

                    case "8":
                        newanimal.ColourNew();
                        newanimal.NameNew();
                        newanimal.SpeciesNew();
                        newanimal.AgeNew();
                        newanimal.FoodNew();
                        newanimal.Info();
                        break;

                    case "9":
                        tiger.Info();
                        lion.Info();
                        cheetah.Info();
                        elephant.Info();
                        giraffe.Info();
                        newanimal.Info();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                // If-statement is used to ask the user if they wish to continue visit the zoo
                Console.WriteLine("Do you want to continue visit the zoo (Y/N)?");
                string response = Console.ReadLine();

                if (response == "N")
                {
                    visit = false;
                    Console.WriteLine("Bye bye!");
                    break;
                }

                else
                {
                    Console.WriteLine("What do you want to do, (1-9)?");
                    reply = Console.ReadLine();
                }
            }
        }
    }
}
    
