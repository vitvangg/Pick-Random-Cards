using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{   
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                string card = RandomValue() + " of " + RandomSuit();
                if (pickCards.Contains(card))
                {
                    i--;
                }
                else
                {
                    pickCards[i] = card;
                }
            }
            return pickCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            switch (value)
            {
                case 1:
                    return "Ace";
                case 11:
                    return "J";
                case 12:
                    return "Q";
                case 13:
                    return "K";
                default:
                    return value.ToString();
            }
        }

        private static string RandomSuit()
        {
            int suit = random.Next(1, 5);
            switch (suit)
            {
                case 1:
                    return "Spades";
                case 2:
                    return "Hearts";
                case 3:
                    return "Clubs";
                default:
                    return "Diamonds";
            }
        }   
    }
}
