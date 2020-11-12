using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Card: IComparable<Card>
    {
        public CardSuit Suit { get; private set; }

        public CardRank Rank { get; private set; }

        public void ShowCard() => Console.Write($"'{Suit}:{Rank}'\n");

        public int CompareTo(Card other)=> Rank.CompareTo(other?.Rank);

        public Card(CardSuit s, CardRank r) {
            Suit = s;
            Rank = r;
        }

    }
}
