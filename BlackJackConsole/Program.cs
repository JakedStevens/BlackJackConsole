using System;
using BlackJackClassLibrary;

namespace BlackJackConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Gambling addictions are fun!");
			Deck deck = new Deck();

			var deck1 = deck.BuildDeck();
			deck.PrintDeck(deck1);

			Console.WriteLine("Shuffle?");
			Console.ReadLine();
			var deck2 = deck.ShuffleDeck(deck1);
			deck.PrintDeck(deck2);

		}
	}
}
