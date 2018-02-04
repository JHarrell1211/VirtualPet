using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace VirtualPet
{
    //private static Timer petTimer;
    public class VirtualPet
    {
        
        private int hunger;
        private int thirst;
        private int tiredness;
        private int waste;
        private int interact;

       

        //Properties
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        } 
        
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }

        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }

        public int Interact
        {
            get { return this.interact; }
            set { this.interact = value; }
        }

        //Constructors
        public VirtualPet()
        {

        }

        public VirtualPet(int hunger, int thirst, int tiredness, int waste, int interact)
        {
            this.hunger = hunger;
            this.thirst = thirst;
            this.tiredness = tiredness;
            this.waste = waste;
            this.interact = interact;
        }

        //Methods

        public void Feed()
        {
                hunger -= 2;
                tiredness += 1;
                waste += 2;
                thirst += 2;
        }

        public void DrinkUp()
        {
                thirst -= 3;
                waste += 1;
        }

        public void IsTired()
        {
                tiredness -= 5;
                hunger += 2;
                waste += 1;
                interact += 1;
        }

        public void Potty()
        {
            if (waste >= 3)
            {
                waste -= 3;
                interact += 2;
            }
        }

        public void Play()
        {
                interact -= 3;
                tiredness += 3;
                hunger += 2;
                thirst += 2;
                waste += 1;
        }

        public void CheckLevels()
        {
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Thirst: " + this.thirst);
            Console.WriteLine("Tiredness: " + this.tiredness);
            Console.WriteLine("Waste: " + this.waste);
            Console.WriteLine("Interact: " + this.interact);
        }

        public void Tick()
        {
            int i;
            Random r = new Random();
            int[] rNum = new int[5];
            

            for (i = 0; i < 5; i++)
            {
                int j = r.Next(-2, 3);
                rNum[i] = j;
            }
            hunger += rNum[0];
            thirst += rNum[1];
            tiredness += rNum[2];
            waste += rNum[3];
            interact += rNum[4];
        }


    }
}

