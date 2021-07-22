using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
    //public class Deck
    //{
    //	public List<Card> Cards { get; set; }
    //}

    public class Deck
    {
        public List<Card> Cards = new List<Card>();
        public void FillDeck()
        {
            //Can use a single loop utilising the mod operator % and Math.Floor
            //Using divition based on 13 cards in a suited
            for (int i = 0; i < 52; i++)
            {
                Card.SuitsEnum suite = (Card.SuitsEnum)(Math.Floor((decimal)i / 13));
                //Add 2 to value as a cards start a 2
                int val = i % 13 + 2;
                Cards.Add(new Card(val, suite));
            }
        }

        public void PrintDeck()
        {
            foreach (Card card in this.Cards)
            {
                Console.WriteLine("{0,2} {1,3} {2,8}", card.NamedValue, "of", card.Suit);

            }
        }
    }
}
