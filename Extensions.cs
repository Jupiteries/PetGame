using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetGame
{
    class Extensions
    {
        public static void ShowStats(Animal animal, Animals animalEnum)
        {
            Random rand = new Random();
            Console.WriteLine($"Name: {animal.Name}");
            Console.WriteLine($"Species: {animalEnum}");
            Console.WriteLine($"Age: {rand.Next(2, 15)}\n");
            Console.Write("Hunger level: ");
            for (int i = 0; i < animal._hunger; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
            Console.Write("Thirst level: ");
            for (int i = 0; i < animal._thirst; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();

            Console.Write("Energy level: ");
            for (int i = 0; i < animal._energy; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();

            Console.Write("Happiness level: ");
            for (int i = 0; i < animal._happiness; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();

            Console.Write("Cleanliness level: ");
            for (int i = 0; i < animal._cleanliness; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();

            Console.Write("Loneliness level: ");
            for (int i = 0; i < animal._loneliness; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
            Console.WriteLine("The attribute points range from 1-5.\n");
            Console.WriteLine($"As you can see, your pet is doing very well. The attributes are going to change according to what you do to {animal.Name}.");
            Console.WriteLine("If you neglect it, it will suffer. If you care for it, it will stay healthy.");
            Console.WriteLine("You can also abandon your pet whenever you wish.");

            Console.WriteLine("Now, let's begin.\n\n");
        }

        public static void Feed(Animal animal, Animals animalEnum)
        {
            int energy = animal.Energy;
            int hunger = animal.Hunger;
            int happiness = animal.Happiness;
            animal._energy += 1;
            animal._hunger -= 1;
            animal._happiness += 1;
            Console.WriteLine($"{animal.Name} has been fed. It enjoyed its meal very much.");
            Console.WriteLine($"Energy +1 ({energy} => {animal.Energy}); Hunger -1 ({hunger} => {animal.Hunger}); Happiness +1 ({happiness} => {animal.Happiness})");
        }
        public static void Drink(Animal animal, Animals animalEnum)
        {
            int energy = animal.Energy;
            int thirst = animal.Thirst;
            int happiness = animal.Happiness;
            animal._energy += 1;
            animal._hunger -= 1;
            animal._happiness += 1;
            Console.WriteLine($"{animal.Name} has been hydrated. How refreshing!");
            Console.WriteLine($"Energy +1 ({energy} => {animal.Energy}); Thirst -1 ({thirst} => {animal.Thirst}); Happiness +1 ({happiness} => {animal.Happiness})");
        }

        public static void Clean(Animal animal, Animals animalEnum)
        {
            int cleanliness = animal.Cleanliness;
            animal._cleanliness += 1;
            Console.WriteLine($"{animal.Name} has been cleaned . It feels much more comfortable now.");
            Console.WriteLine($"Cleanliness +2 ({cleanliness} => {animal.Cleanliness})");
        }

        public static void Play(Animal animal, Animals animalEnum)
        {
            int energy = animal.Energy;
            int hunger = animal.Hunger;
            int thirst = animal.Thirst;
            int happiness = animal.Happiness;
            animal._energy -= 2;
            animal._hunger += 2;
            animal._thirst += 1;
            animal._happiness += 2;
            Console.WriteLine($"You played with {animal.Name}. It's very happy now.");
            Console.WriteLine($"Energy -2 ({energy} => {animal.Energy}); Hunger +2 ({hunger} => {animal.Hunger}); Thirst +1 ({thirst} => {animal.Thirst}); Happiness +2 ({happiness} => {animal.Happiness})");
        }

        public static void Sleep(Animal animal, Animals animalEnum)
        {
            int energy = animal.Energy;
            int hunger = animal.Hunger;
            int thirst = animal.Thirst;
            animal._energy += 3;
            animal._hunger += 2;
            animal._thirst += 2;
            Console.WriteLine($"{animal.Name} has slept well.");
            Console.WriteLine($"Energy +3 ({energy} => {animal.Energy}); Hunger +2 ({hunger} => {animal.Hunger}); Thirst +2 ({thirst} => {animal.Thirst})");
        }

        public static void Fight(Animal animal, Animals animalEnum)
        {
            int energy = animal.Energy;
            int hunger = animal.Hunger;
            int thirst = animal.Thirst;
            int happiness = animal.Happiness;
            int loneliness = animal.Loneliness;
            animal._energy -= 4;
            animal._hunger += 3;
            animal._thirst += 3;
            animal._happiness -= 1;
            animal._loneliness += 2;
            Console.WriteLine($"You have sent {animal.Name} to a battle royale. It has fought well, achieving victory. However, it did not enjoy it.");
            Console.WriteLine($"Energy -4 ({energy} => {animal.Energy}); Hunger +3 ({hunger} => {animal.Hunger}); Thirst +3 ({thirst} => {animal.Thirst}); Happiness -1 ({happiness} => {animal.Happiness}); Loneliness +2 ({loneliness} => {animal.Loneliness})");
        }

        public static void Hug(Animal animal, Animals animalEnum)
        {
            int energy = animal.Energy;
            int happiness = animal.Happiness;
            int loneliness = animal.Loneliness;
            animal._energy += 1;
            animal._happiness += 3;
            animal._loneliness -= 2;
            Console.WriteLine($"You have sent {animal.Name} to a battle royale. It has fought well, achieving victory. However, it did not enjoy it.");
            Console.WriteLine($"Energy +1 ({energy} => {animal.Energy}); Happiness +3 ({happiness} => {animal.Happiness}); Loneliness -2 ({loneliness} => {animal.Loneliness})");
        }

        public static void Abandon(Animal animal, Animals animalEnum)
        {
            Console.WriteLine($"Are you sure you want to abandon {animal.Name}? After all you've been through together, you're going to abandon it so cruelly? (y/n)");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "y")
            {
                Console.WriteLine($"You still have a chance to think about it. If you abandon the {animalEnum}, you will never see it again (y/n).");
                string secondUserAnswer = Console.ReadLine();
                if (secondUserAnswer == "y")
                {
                    Console.WriteLine($"You broke the news to {animal.Name}, and it started whimpering. Hugging your leg, it refused to go away, but you kicked it coldly and mercilessly. Helpess and unable to get up, {animal.Name} stared at your figure moving further and further away with tears in its eyes. After you finally disappeared, unable to handle the heartache, {animal.Name} collapsed.");
                    Console.WriteLine("Happiness -5; Energy -5;");
                    Console.WriteLine("\nLoneliness +10.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"You have made the right decision. Make sure {animal.Name} never hears of this...");
                }
            }
            else
            {
                Console.WriteLine($"You have made the right decision. Make sure {animal.Name} never hears of this...");
            }
            
        }

    }
}
