using System;

namespace Game304.Core
{
    public class Deck : IDeck
    {
        private readonly Card[] _cards = new []
        {
             Card.Spade.Jack, 
             Card.Spade.Nine,
             Card.Spade.Ace,
             Card.Spade.Ten,
             Card.Spade.King,
             Card.Spade.Queen,
             Card.Spade.Eight,
             Card.Spade.Seven,
             Card.Heart.Jack, 
             Card.Heart.Nine,
             Card.Heart.Ace,
             Card.Heart.Ten,
             Card.Heart.King,
             Card.Heart.Queen,
             Card.Heart.Eight,
             Card.Heart.Seven,
             Card.Diamond.Jack, 
             Card.Diamond.Nine,
             Card.Diamond.Ace,
             Card.Diamond.Ten,
             Card.Diamond.King,
             Card.Diamond.Queen,
             Card.Diamond.Eight,
             Card.Diamond.Seven,
             Card.Club.Jack, 
             Card.Club.Nine,
             Card.Club.Ace,
             Card.Club.Ten,
             Card.Club.King,
             Card.Club.Queen,
             Card.Club.Eight,
             Card.Club.Seven
        };

        public Card[] Cards
        {
            get { return _cards; }
        }

        public void Shuffle()
        {
            for (int i = 0; i < Cards.Length; i++)
            {
                var random = i + new Random(i).Next(Cards.Length - i);
                Swap(i, random);
            }
        }

        private void Swap(int from, int to)
        {
            Card temp = Cards[from];
            Cards[from] = Cards[to];
            Cards[to] = temp;
        }
    }
}