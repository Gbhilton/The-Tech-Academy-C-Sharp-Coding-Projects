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

            Deck deck = new Deck();

            int counter = 0;


            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

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
