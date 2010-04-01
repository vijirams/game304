using Game304.Core;
using NUnit.Framework;

namespace Game304.UnitTests
{
    [TestFixture]
    public class HandTest
    {
        [Test]
        public void Has8Cards()
        {
            var hand = new Hand();
            Assert.AreEqual(8, hand.Cards.Length);
        }

        [Test]
        public void IsEmpty_True_WhenNoCardsOnHand()
        {
            var hand = new Hand();
            Assert.IsTrue(hand.IsEmpty);
        }

        [Test]
        public void IsNotEmpty_False_CardsAddedToHand()
        {
            var hand = new Hand();
            hand.Add(new[] { Card.Spade.Jack, Card.Spade.Nine, Card.Spade.Ace, Card.Spade.Ten });
            Assert.IsFalse(hand.IsEmpty);
        }

        [Test]
        public void AddCards_WhenHandEmpty()
        {
            var hand = new Hand();
            hand.Add(new[] { Card.Spade.Jack, Card.Spade.Nine, Card.Spade.Ace, Card.Spade.Ten });
            Assert.AreEqual(Card.Spade.Jack, hand.Cards[0]);
            Assert.AreEqual(Card.Spade.Nine, hand.Cards[1]);
            Assert.AreEqual(Card.Spade.Ace, hand.Cards[2]);
            Assert.AreEqual(Card.Spade.Ten, hand.Cards[3]);
        }

        [Test]
        public void AddCards_WhenHandHalfEmpty()
        {
            var hand = new Hand();
            hand.Add(new[] { Card.Spade.Jack, Card.Spade.Nine, Card.Spade.Ace, Card.Spade.Ten });
            hand.Add(new[] { Card.Heart.Jack, Card.Heart.Nine, Card.Heart.Ace, Card.Heart.Ten });
            Assert.AreEqual(Card.Heart.Jack, hand.Cards[4]);
            Assert.AreEqual(Card.Heart.Nine, hand.Cards[5]);
            Assert.AreEqual(Card.Heart.Ace, hand.Cards[6]);
            Assert.AreEqual(Card.Heart.Ten, hand.Cards[7]);
        }

        [Test]
        public void Points()
        {
            var hand = new Hand();
            hand.Add(new[] { Card.Spade.Jack, Card.Spade.Nine, Card.Spade.Ace, Card.Spade.Ten });
            Assert.AreEqual(71, hand.Points);
        }
    }
}