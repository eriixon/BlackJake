using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Cards
{
    public class CardSet
    {
        public List<Card> cardset;
        public CardSet()
        {
            cardset = SetCardSet();
        }

        private List<Card> SetCardSet()
        {
            List<Card> cardSetSetup = new List<Card>
            {
                new Card (CardSuit.Clubs, "Ace"),
                new Card (CardSuit.Clubs, "King"),
                new Card (CardSuit.Clubs, "Queen"),
                new Card (CardSuit.Clubs, "Jake"),
                new Card (CardSuit.Clubs, "10"),
                new Card (CardSuit.Clubs, "9"),
                new Card (CardSuit.Clubs, "8"),
                new Card (CardSuit.Clubs, "7"),
                new Card (CardSuit.Clubs, "6"),

                new Card (CardSuit.Diamonds, "Ace"),
                new Card (CardSuit.Diamonds, "King"),
                new Card (CardSuit.Diamonds, "Queen"),
                new Card (CardSuit.Diamonds, "Jake"),
                new Card (CardSuit.Diamonds, "10"),
                new Card (CardSuit.Diamonds, "9"),
                new Card (CardSuit.Diamonds, "8"),
                new Card (CardSuit.Diamonds, "7"),
                new Card (CardSuit.Diamonds, "6"),

                new Card (CardSuit.Hearts, "Ace"),
                new Card (CardSuit.Hearts, "King"),
                new Card (CardSuit.Hearts, "Queen"),
                new Card (CardSuit.Hearts, "Jake"),
                new Card (CardSuit.Hearts, "10"),
                new Card (CardSuit.Hearts, "9"),
                new Card (CardSuit.Hearts, "8"),
                new Card (CardSuit.Hearts, "7"),
                new Card (CardSuit.Hearts, "6"),

                new Card (CardSuit.Pikes, "Ace"),
                new Card (CardSuit.Pikes, "King"),
                new Card (CardSuit.Pikes, "Queen"),
                new Card (CardSuit.Pikes, "Jake"),
                new Card (CardSuit.Pikes, "10"),
                new Card (CardSuit.Pikes, "9"),
                new Card (CardSuit.Pikes, "8"),
                new Card (CardSuit.Pikes, "7"),
                new Card (CardSuit.Pikes, "6")
            };
            return cardSetSetup;
        }
    }
}
