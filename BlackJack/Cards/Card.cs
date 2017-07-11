using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Cards
{
    public class Card : ICard
    {
        public CardSuit Suit { get; set; }
        public string CardRange { get; set; }
        public Card(CardSuit suit, string range)
        {
            Suit = suit;
            CardRange = range;
        }
    }
}
