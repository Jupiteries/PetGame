using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetGame
{
    class Play
    {
        public static void Start(Animals animalEnum, Animal animal)
        {
            Console.WriteLine("Greetings, traveller. You have encountered a once-in-a-lifetime chance to take in a mythical creature. Choose the creature you want as your pet:");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}: {(Animals)i}");
            }
            Console.WriteLine("Enter your chosen companion (Enter the number, e.g. '1', '4', etc.: ");
            wrongFormat:
            if (!int.TryParse(Console.ReadLine(), out int chosenCreature))
            {
                Console.WriteLine("Write an integer! Try again:");
                goto wrongFormat;
            }
            switch (chosenCreature)
            {
                case 1:
                    Console.WriteLine("You have chosen the dragon as your companion");
                    animalEnum = Animals.Dragon;
                    break;
                case 2:
                    Console.WriteLine("You have chosen the hydra as your companion");
                    animalEnum = Animals.Hydra;
                    break;
                case 3:
                    Console.WriteLine("You have chosen the basilisk as your companion");
                    animalEnum = Animals.Basilisk;
                    break;
                case 4:
                    Console.WriteLine("You have chosen the chameleon as your companion");
                    animalEnum = Animals.Chameleon;
                    break;
                case 5:
                    Console.WriteLine("You have chosen the unicorn as your companion");
                    animalEnum = Animals.Unicorn;
                    break;
                case 6:
                    Console.WriteLine("You have chosen the manticore as your companion");
                    animalEnum = Animals.Manticore;
                    break;
                case 7:
                    Console.WriteLine("You have chosen the hippogriff as your companion");
                    animalEnum = Animals.Hippogriff;
                    break;
                case 8:
                    Console.WriteLine("You have chosen the phoenix as your companion");
                    animalEnum = Animals.Phoenix;
                    break;
                case 9:
                    Console.WriteLine("You have chosen the leprechaun as your companion");
                    animalEnum = Animals.Leprechaun;
                    break;
            }
            Console.WriteLine($"Now, it's time to name your {animalEnum}. Enter its name:");
            wrongNameFormat:
            string animalsName = Console.ReadLine();
            if (string.IsNullOrEmpty(animalsName) || string.IsNullOrWhiteSpace(animalsName))
            {
                Console.WriteLine($"You must name your {animalEnum} something. Try again:");
                goto wrongNameFormat;
            }
            animal.Name = animalsName;
            Console.WriteLine($"\nYour {animalEnum}s name is now {animal.Name}. Make sure to treat it well.\n");
            PlayTheGame(animalEnum, animal);
        }

        public static void PlayTheGame(Animals animalEnum, Animal animal)
        {
            Console.WriteLine("Before you begin, you can look at your pets interface:\n");
            Extensions.ShowStats(animal, animalEnum);
            while (true)
            {
                Console.WriteLine("What do you want to do with your pet?\n");
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine($"{i}: {(Actions)i}");
                }
                Console.WriteLine("9: Open stats window.");
                Console.WriteLine("10: Exit the game. Changes will not be saved.");
                Console.WriteLine("\nEnter the number: ");
            wrongActionFormat:
                if (!int.TryParse(Console.ReadLine(), out int chosenAction))
                {
                    Console.WriteLine("Write an integer! Try again:");
                    goto wrongActionFormat;
                }
                switch (chosenAction)
                {
                    case 1:
                        Extensions.Feed(animal, animalEnum);
                        break;
                    case 2:
                        Extensions.Drink(animal, animalEnum);
                        break;
                    case 3:
                        Extensions.Clean(animal, animalEnum);
                        break;
                    case 4:
                        Extensions.Play(animal, animalEnum);
                        break;
                    case 5:
                        Extensions.Sleep(animal, animalEnum);
                        break;
                    case 6:
                        Extensions.Fight(animal, animalEnum);
                        break;
                    case 7:
                        Extensions.Hug(animal, animalEnum);
                        break;
                    case 8:
                        Extensions.Abandon(animal, animalEnum);
                        break;
                    case 9:
                        Extensions.ShowStats(animal, animalEnum);
                        break;
                    case 10:
                        Console.WriteLine("Exiting, have a good day.");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
