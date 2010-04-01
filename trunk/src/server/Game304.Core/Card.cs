using System.Collections.Generic;

namespace Game304.Core
{
    public class Card
    {
        private static readonly Dictionary<Face, int> PointTable = new Dictionary<Face, int> 
        {
            { Face.Jack, 30 },
            { Face.Nine, 20 },
            { Face.Ace, 11 },
            { Face.Ten, 10 },
            { Face.King, 3 },
            { Face.Queen, 2 },
            { Face.Eight, 0 },
            { Face.Seven, 0 },
        };

        private Card(Suit suit, Face face)
        {
            Suit = suit;
            Face = face;
        }

        public Suit Suit { get; private set; }

        public Face Face { get; private set; }

        public int Points 
        {
            get { return PointTable[Face]; }
        }

        public static class Spade
        {
            public static Card Jack = new Card(Suit.Spade, Face.Jack);
            public static Card Nine = new Card(Suit.Spade, Face.Nine);
            public static Card Ace = new Card(Suit.Spade, Face.Ace);
            public static Card Ten = new Card(Suit.Spade, Face.Ten);
            public static Card King = new Card(Suit.Spade, Face.King);
            public static Card Queen = new Card(Suit.Spade, Face.Queen);
            public static Card Eight = new Card(Suit.Spade, Face.Eight);
            public static Card Seven = new Card(Suit.Spade, Face.Seven);
        }

        public static class Heart
        {
            public static Card Jack = new Card(Suit.Heart, Face.Jack);
            public static Card Nine = new Card(Suit.Heart, Face.Nine);
            public static Card Ace = new Card(Suit.Heart, Face.Ace);
            public static Card Ten = new Card(Suit.Heart, Face.Ten);
            public static Card King = new Card(Suit.Heart, Face.King);
            public static Card Queen = new Card(Suit.Heart, Face.Queen);
            public static Card Eight = new Card(Suit.Heart, Face.Eight);
            public static Card Seven = new Card(Suit.Heart, Face.Seven);
        }

        public static class Diamond
        {
            public static Card Jack = new Card(Suit.Diamond, Face.Jack);
            public static Card Nine = new Card(Suit.Diamond, Face.Nine);
            public static Card Ace = new Card(Suit.Diamond, Face.Ace);
            public static Card Ten = new Card(Suit.Diamond, Face.Ten);
            public static Card King = new Card(Suit.Diamond, Face.King);
            public static Card Queen = new Card(Suit.Diamond, Face.Queen);
            public static Card Eight = new Card(Suit.Diamond, Face.Eight);
            public static Card Seven = new Card(Suit.Diamond, Face.Seven);
        }

        public static class Club
        {
            public static Card Jack = new Card(Suit.Club, Face.Jack);
            public static Card Nine = new Card(Suit.Club, Face.Nine);
            public static Card Ace = new Card(Suit.Club, Face.Ace);
            public static Card Ten = new Card(Suit.Club, Face.Ten);
            public static Card King = new Card(Suit.Club, Face.King);
            public static Card Queen = new Card(Suit.Club, Face.Queen);
            public static Card Eight = new Card(Suit.Club, Face.Eight);
            public static Card Seven = new Card(Suit.Club, Face.Seven);
        }
    }
}