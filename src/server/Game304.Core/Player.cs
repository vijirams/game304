namespace Game304.Core
{
    public class Player
    {
        public Player()
        {
            Hand = new Hand();
        }

        public Hand Hand { get; private set; }

        public void Take(Card[] cards)
        {
            if (Hand.IsEmpty)
            {
                Hand.Add(cards);
            }
        }
    }
}