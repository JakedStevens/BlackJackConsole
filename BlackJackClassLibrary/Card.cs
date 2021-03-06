using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackClassLibrary
{
    public class Card
    {
        public enum SuitsEnum
        {
            Diamonds = 0,
            Hearts = 1,
            Spades = 2,
            Clubs = 3
        }

        public int Value { get; set; }
        public SuitsEnum Suit { get; set; }

        public string NamedValue
        {
            get
            {
                string name = string.Empty;
                switch (Value)
                {
                    case (14):
                        name = "A";
                        break;
                    case (13):
                        name = "K";
                        break;
                    case (12):
                        name = "Q";
                        break;
                    case (11):
                        name = "J";
                        break;
                    default:
                        name = Value.ToString();
                        break;
                }
                return name;
            }
        }

        public Card(int value, SuitsEnum suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
    }
}
