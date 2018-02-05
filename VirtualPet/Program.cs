using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace VirtualPet
{
    public class Program
    {
        static void Main(string[] args)
        {
            VirtualPet bruce = new VirtualPet(0, 6, 1, 4, 9);
            Random r = new Random();
            string[] rFood = new string[4];
            string[] rInteract = new string[2];
            string userChoice = " ";

            Timer
            petTimer = new System.Timers.Timer();
            petTimer.Interval = 12000; // 12 second intervals

            petTimer.AutoReset = true;  // Resets for repeated events

            petTimer.Enabled = true;  // Start timer

            petTimer.Elapsed += Event;  // Create event after elapsed time

            void Event(Object source, System.Timers.ElapsedEventArgs e)
            {
                bruce.Tick();
                Console.WriteLine("Bruce's levels have changed!!");  // Prints every 12 seconds to notify user
            }

            Console.WriteLine("Bruce the Panther");
            Console.WriteLine("Keep levels as close to zero as possible");
            Console.WriteLine("Bruce's levels randomly change every 12 seconds \n");

            while (userChoice != "7")
            {
                Console.WriteLine("What would you like to do? \n");
                Console.WriteLine("1. Feed Bruce");
                Console.WriteLine("2. Give Bruce Water");
                Console.WriteLine("3. Take Bruce out to potty");
                Console.WriteLine("4. Interact with Bruce");
                Console.WriteLine("5. Let Bruce Sleep");
                Console.WriteLine("6. Check Bruce's levels");
                Console.WriteLine("7. Exit");
                userChoice = (Console.ReadLine());

                switch (userChoice)
                {
                    case "1":
                        if (bruce.Hunger  >= 2)
                        {
                            bruce.Feed();
                            Console.WriteLine("You fed Bruce " + Foods(rFood));
                        }
                        else
                        {
                            Console.WriteLine("Bruce walks away, he is not hungry");
                        }
                        break;

                    case "2":
                        bruce.DrinkUp();
                        break;

                    case "3":
                        bruce.Potty();
                        break;

                    case "4":
                        if (bruce.Interact >= 3)
                        {
                            bruce.Play();
                            Console.WriteLine(Interactions(rInteract));
                        }
                        else
                        {
                            Console.WriteLine("Bruce growls at you, he is not in the mood to play");
                        }
                        break;

                    case "5":
                        bruce.IsTired();
                        break;

                    case "6":
                        bruce.CheckLevels();
                        break;

                    case "7":
                        Console.WriteLine("Bruce doesn't like to be alone and stares angrily as you walk away....");
                        break;
                }
                Console.WriteLine("");
            }
        }       
      
        static string Foods(string[] rFoods)
        {
            int i;
            Random r = new Random();
            string[] rFood = new string[4];

            rFood[0] = "chicken";
            rFood[1] = "steak";
            rFood[2] = "pork chops";
            rFood[3] = "vegetables";

            i = r.Next(0, 4);

            return rFood[i];
        }

        static string Interactions(string[] rInteract)
        {
            int i;
            string[] rActions = new string[2];
            Random r = new Random();
            rActions[0] = "You walk Bruce, now everyone in the neighborhood is frightened. The old lady across the street calls the police.";
            rActions[1] = "You let Bruce chase you around the yard. You laugh and cry as you hope he doesn't kill you";

            i = r.Next(0, 2);
            return rActions[i];
        }
    }
}
