using System.Linq;

namespace Game304.Core
{
    public class Hand
    {
        private readonly Card[] _cards = new Card[8];

        public Card[] Cards
        {
            get { return _cards; }
        }

        public bool IsEmpty
        {
            get { return _cards[0] == null; }
        }

        public int Points
        {
            get { return _cards.Where(c => c != null).Sum(c => c.Points); }
        }

        public void Add(Card[] cards)
        {
            int offset = IsEmpty ? 0 : 4;
            for (int i = 0; i < 4; i++)
            {
                _cards[i + offset] = cards[i];
            }
        }
    }
}