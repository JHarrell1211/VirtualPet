using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
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
            if (hunger >= 2)
            {
                hunger -= 2;
                tiredness += 1;
                waste += 2;
                thirst += 2;
            }
        }

        public void DrinkUp()
        {
            if (thirst >= 2)
            {
                thirst -= 3;
                waste += 1;
            }
        }

        public void IsTired()
        {
        if (tiredness >= 5)
            {
                tiredness -= 5;
                hunger += 2;
                waste += 1;
                interact += 1;
            }
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
            if (interact >= 3)
            {
                interact -= 3;
                tiredness += 3;
                hunger += 2;
                thirst += 2;
                waste += 1;
            }
        }

        public void Tick()
        {

        }


    }
}

