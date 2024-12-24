using System;

namespace PetGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animalEnum = new Animals();
            Actions action = new Actions();
            Animal animal = new Animal();

            animal._hunger = 1;
            animal._thirst = 1;
            animal._happiness = 5;
            animal._energy = 5;
            animal._cleanliness = 5;
            animal._loneliness = 1;

            Play.Start(animalEnum, animal);
        }
    }
}
