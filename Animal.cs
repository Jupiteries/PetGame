using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetGame
{
    class Animal
    {
        public string Name { get; set; }

        public int _hunger;
        public int _thirst;
        public int _energy;
        public int _happiness;
        public int _cleanliness;
        public int _loneliness;

        public int Hunger
        {
            get
            {
                if (_hunger < 1) return 1;
                else if (_hunger > 5) return 5;
                else { return _hunger; }

            }
            set
            {
                if (value < 1) _hunger = 1;
                else if (value > 5) _hunger = 5;
                else { _hunger = value; }
            }
        }
        public int Thirst
        {
            get
            {
                if (_thirst < 1) return 1;
                else if (_thirst > 5) return 5;
                else { return _thirst; }

            }
            set
            {
                if (value < 1) _thirst = 1;
                else if (value > 5) _thirst = 5;
                else { _thirst = value; }
            }
        }
        public int Energy
        {
            get
            {
                if (_energy < 1) return 1;
                else if (_energy > 5) return 5;
                else { return _energy; }

            }
            set
            {
                if (value < 1) _energy = 1;
                else if (value > 5) _energy = 5;
                else { _energy = value; }
            }
        }
        public int Happiness
        {
            get
            {
                if (_happiness < 1) return 1;
                else if (_happiness > 5) return 5;
                else { return _happiness; }

            }
            set
            {
                if (value < 1) _happiness = 1;
                else if (value > 5) _happiness = 5;
                else { _happiness = value; }
            }
        }
        public int Cleanliness
        {
            get
            {
                if (_cleanliness < 1) return 1;
                else if (_cleanliness > 5) return 5;
                else { return _cleanliness; }

            }
            set
            {
                if (value < 1) _cleanliness = 1;
                else if (value > 5) _cleanliness = 5;
                else { _cleanliness = value; }
            }
        }
        public int Loneliness
        {
            get
            {
                if (_loneliness < 1) return 1;
                else if (_loneliness > 5) return 5;
                else { return _loneliness; }

            }
            set
            {
                if (value < 1) _loneliness = 1;
                else if (value > 5) _loneliness = 5;
                else { _loneliness = value; }
            }
        }
    }
}
