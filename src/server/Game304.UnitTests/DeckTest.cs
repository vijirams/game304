using System;
using NUnit.Framework;
using Game304.Core;

namespace Game304.UnitTests
{
    [TestFixture]
    public class DeckTest
    {
        private static readonly Suit[] SuitTable = new[] { Suit.Spade, Suit.Heart, Suit.Diamond, Suit.Club };
        private static readonly Face[] FaceTable = new[] { Face.Jack, Face.Nine, Face.Ace, Face.Ten, Face.King, Face.Queen, Face.Eight, Face.Seven };

        [Test]
        public void NewDeck_32CardsInOrder()
        {
            var deck = new Deck();
            Assert.IsTrue(CardsInOrder(deck.Cards));
        }

        [Test]
        public void Shuffle_NotInOrder()
        {
            var deck = new Deck();
            deck.Shuffle();
            Assert.IsFalse(CardsInOrder(deck.Cards));
        }

        private static bool CardsInOrder(Card[] cards)
        {
            if (cards.Length != 32)
            {
                return false;
            }

            for (int i = 0; i < 32; i++)
            {
                Suit suit = SuitTable[i/8];
                Face face = FaceTable[i%8];           
                if (cards[i].Suit != suit || cards[i].Face != face)
                {
                    return false;
                }
            }
            return true;
        }
    }
}