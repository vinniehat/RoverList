using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> BestBands = new RoverList<string>();

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words
            BestBands.Add("Radiohead");
            BestBands.Add("Depeche Mode");
            BestBands.Add("Foo Fighters");
            BestBands.Add("Odesza");
            BestBands.Add("Pet Shop Boys");
            BestBands.Add("INXS");
            BestBands.Add("Nine Inch Nails");
            BestBands.Add("Muse");
            BestBands.Add("Weezer");
            BestBands.Add("The Cure");
            BestBands.Add("Nirvana");
            BestBands.Add("Linkin Park");
            BestBands.Add("Tears for Fears");
            BestBands.Add("Bon Jovi");
            BestBands.Add("New Order");
            BestBands.Add("Green Day");
            
            
            // TODO:  Print out the list
            BestBands.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            Console.WriteLine("Ok, go add your bands. Because they stink, they go to the bottom.");
            Console.Write("Enter Band Name Here(type \"done\" to end your list): ");
            while (true) {
                Console.Write("> ");
                var band = Console.ReadLine();
                if (band == "done") {
                    break;
                } else {
                    BestBands.Add(band);
                }
            }
            
            // TODO:  Print out the list
            Console.WriteLine("--------------------------");
            Console.WriteLine("Let's see these new bands");
            BestBands.ListNodes();

            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            Console.WriteLine("Alright.. I hear you have some better bands??? Pff.. Let's hear them.");
            Console.Write("Enter Band Name Here(type \"done\" to end your list): ");
            while (true) {
                Console.Write("> ");
                var band = Console.ReadLine();
                if (band == null) continue;
                if (band.ToLower() == "done") {
                    break;
                } else {
                    BestBands.Add(1, band);
                }
            }
            
            // TODO:  Print out the list
            Console.WriteLine("--------------------------");
            Console.WriteLine("Let's see these new bands");
            BestBands.ListNodes();
           

            // TODO:  Remove every word with an odd length
            for (int i = BestBands.Count - 1; i>= 0; i--) {
                string word = BestBands.ElementAt(i);
                if (word.Length % 2 == 1) {
                    BestBands.RemoveAt(i);
                }
            }
            // TODO:  Print out the list
            Console.WriteLine("--------------------------");
            BestBands.ListNodes();

            // TODO:  Clear the list
            BestBands.Clear();
            // TODO:  Print out the list
            BestBands.ListNodes();


        }
    }
}
