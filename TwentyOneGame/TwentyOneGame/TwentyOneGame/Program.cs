using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yea" || answer == "y" || answer == "yesh" || answer == "ya" || answer == "yep")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOne();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();


            //THE BELOW CODE ARE EXAMPLES AND AND CODE FROM EXERCISES i USED WHILE MAKING THIS PROGRAM.
            //For each loop/creating the deck and writing all the cards in the deck to the console.
            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();

            //Lambda function example for counting all the aces in the "deck".
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);
            //Lambda function example for creating a new list of cards with just Kings.
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //Lambda function example for creating a new list of cards with just Kings.
            //List<int> numberList = new List<int>() { 1, 2, 3, 345, 555, 657 };
            //int sum = numberList.Where(x => x > 20).Sum();
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //Adding a new player to the game after overloading an operator (+/-)
            //Game game = new TwentyOne();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Grant";
            //game = game + player;

            //Polymorphism: The property of classes to morph into other types classes.
            //List<Game> games = new List<Game>;
            //Game game = new TwentyOne();
            //games.Add(game);

            //Created a list of players
            //Game game = new Game();
            //game.Players = new List<string>() { "Grant", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();

            //This is a parameter with two inputs.
            //public static Deck Shuffle(Deck deck, int times)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        deck = Shuffle(deck);
            //    }
            //    return deck;
            //}
        }
    }
}
