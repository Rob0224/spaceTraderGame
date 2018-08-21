using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTrader
{
    class Program
    {
        static void Main(string[] args)
        {
            compelingStory();
            gameTitle();
            spaceShipchoice();
        }

        public static void compelingStory()
        {
            Console.WriteLine("Trading has been a way of making currency since man first stepped foot on earth," +
              " but what about trading acrosss galaxys?");
            Console.WriteLine("Now with great advancements in technology we have made a connection between neighboring planets Alpha Centori" +
                "and myGreatPlanet.");
            Console.WriteLine("With new found research we have established a method of travel allowing access to our neighboring planets resources.");
              Console.WriteLine("These resources are allowing scientistw to further advance our world.");
            Console.WriteLine("but no item is free we have developed a trading system based off their want for our supplies," +
                "and our want for theirs.");
            Console.WriteLine("Keep in mind while traveling through space one must be mentally sound, courageous and not be afraid of danger.");
            Console.WriteLine("You are about to embark on a journey man has rarely traveled, will you travell the distance and risk everything?");
            Console.WriteLine("Will you defeat the unknown and live in everlasting wealth? You decide!");
            Console.WriteLine("Press 'enter' to continue");
            Console.ReadLine();
            Console.Clear();
        }
        public static void gameTitle()
        {
            // this below text welcomes the user to the game
            Console.WriteLine("Greetings fellow adventurer, welcome to my game space trader.");
            Console.WriteLine("Please enter your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("Greetings " + playerName);
            Console.WriteLine("Press 'enter' to begin.");
            Console.ReadLine();
            //console.clear wil clear out the screen
            Console.Clear();
          

        }


        public static void spaceShipchoice()
        {
            string choice; 

            Console.WriteLine("There are two ships to select from");
            Console.WriteLine("Which one would you like to choose?");
            Console.ReadLine();
            Console.WriteLine("1. The Aluminum Can");
            Console.WriteLine("2. The Garbage Gatherer");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "The Aluminum Can":
                case "Aluminum Can":
                    {
                        Console.WriteLine("Excellent choice, traveler may the aluminum can treat you well.");
                        Console.WriteLine(" The odds will be in your favor, always remember to recycle.");
                        Console.WriteLine("Press 'enter' to continue.");
                        Console.ReadLine();
                        spaceshipStats();
                        break;
                    }
                case "2":
                case "The Garbage Gatherer":
                case "Garbage Gatherer":
                    {
                        Console.WriteLine("Quite the taste full decision Space Trader, May the Garbage Gatherer treat you well.");
                        Console.WriteLine("The universe will surely know your smell, one mans trash is another mans treasure!");
                        Console.WriteLine("Press 'enter' to continue");
                        spaceshipStats();
                        break;
                    }
                default:

                    {

                    }
                    Console.WriteLine("I do not understand that command .......");
                    Console.WriteLine("Please try again.");
                    Console.ReadLine();
                    Console.Clear();
                    spaceShipchoice();
                    break;

            }
        }

        public static void spaceshipStats()
        {

        }
        public static void otherWorlds()
        {

        }
        public static void tradeShop()
        {

        }
        public static void gameOver()
        {

        }
        public static void youWin()
        {

        }
    }


}
