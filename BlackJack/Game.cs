using BlackJack.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Game
    {
        public CardSet set = new CardSet();

        public int CheckBlackJack(List<int> cards)
        {
            return cards.Sum();
        }
    }
}
