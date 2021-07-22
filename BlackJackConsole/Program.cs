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

			deck.FillDeck();
			deck.PrintDeck();
		}
	}
}
