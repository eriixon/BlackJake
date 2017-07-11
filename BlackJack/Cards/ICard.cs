using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Cards
{
    public enum CardSuit {Diamonds,Clubs,Pikes,Hearts};

    public interface ICard
    {
        CardSuit Suit { get; set; }
        string CardRange { get; set; }
    }
}
