using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
	public class Deck
    {
        public List<Card> Cards { get; set; }

        public List<Card> BuildDeck()
        {
            var cards = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                Card.SuitsEnum suite = (Card.SuitsEnum)(Math.Floor((decimal)i / 13));
                int val = i % 13 + 2;
                cards.Add(new Card(val, suite));
            }
            return cards;
        }

        public void PrintDeck(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine("{0,2} {1,2} {2,1}", card.NamedValue, "of", card.Suit);

            }
        }

		public List<Card> ShuffleDeck(List<Card> cards)
		{
			var rnd = new Random();
            var shuffledDeck = cards.OrderBy(item => rnd.Next()).ToList();
            return shuffledDeck;
		}
	}
}
