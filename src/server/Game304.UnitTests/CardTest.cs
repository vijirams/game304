using Game304.Core;
using NUnit.Framework;

namespace Game304.UnitTests
{
    [TestFixture]
    public class CardTest
    {
        #region Spades
        [Test]
        public void SpadeJack()
        {
            AssertCard(Card.Spade.Jack, Suit.Spade, Face.Jack, 30);
        }

        [Test]
        public void SpadeNine()
        {
            AssertCard(Card.Spade.Nine, Suit.Spade, Face.Nine, 20);
        }

        [Test]
        public void SpadeAce()
        {
            AssertCard(Card.Spade.Ace, Suit.Spade, Face.Ace, 11);
        }

        [Test]
        public void SpadeTen()
        {
            AssertCard(Card.Spade.Ten, Suit.Spade, Face.Ten, 10);
        }

        [Test]
        public void SpadeKing()
        {
            AssertCard(Card.Spade.King, Suit.Spade, Face.King, 3);
        }

        [Test]
        public void SpadeQueen()
        {
            AssertCard(Card.Spade.Queen, Suit.Spade, Face.Queen, 2);
        }

        [Test]
        public void SpadeEight()
        {
            AssertCard(Card.Spade.Eight, Suit.Spade, Face.Eight, 0);
        }

        [Test]
        public void SpadeSeven()
        {
            AssertCard(Card.Spade.Seven, Suit.Spade, Face.Seven, 0);
        }
        #endregion

        #region Hearts
        [Test]
        public void HeartJack()
        {
            AssertCard(Card.Heart.Jack, Suit.Heart, Face.Jack, 30);
        }

        [Test]
        public void HeartNine()
        {
            AssertCard(Card.Heart.Nine, Suit.Heart, Face.Nine, 20);
        }

        [Test]
        public void HeartAce()
        {
            AssertCard(Card.Heart.Ace, Suit.Heart, Face.Ace, 11);
        }

        [Test]
        public void HeartTen()
        {
            AssertCard(Card.Heart.Ten, Suit.Heart, Face.Ten, 10);
        }

        [Test]
        public void HeartKing()
        {
            AssertCard(Card.Heart.King, Suit.Heart, Face.King, 3);
        }

        [Test]
        public void HeartQueen()
        {
            AssertCard(Card.Heart.Queen, Suit.Heart, Face.Queen, 2);
        }

        [Test]
        public void HeartEight()
        {
            AssertCard(Card.Heart.Eight, Suit.Heart, Face.Eight, 0);
        }

        [Test]
        public void HeartSeven()
        {
            AssertCard(Card.Heart.Seven, Suit.Heart, Face.Seven, 0);
        }
        #endregion

        #region Diamond
        [Test]
        public void DiamondJack()
        {
            AssertCard(Card.Diamond.Jack, Suit.Diamond, Face.Jack, 30);
        }

        [Test]
        public void DiamondNine()
        {
            AssertCard(Card.Diamond.Nine, Suit.Diamond, Face.Nine, 20);
        }

        [Test]
        public void DiamondAce()
        {
            AssertCard(Card.Diamond.Ace, Suit.Diamond, Face.Ace, 11);
        }

        [Test]
        public void DiamondTen()
        {
            AssertCard(Card.Diamond.Ten, Suit.Diamond, Face.Ten, 10);
        }

        [Test]
        public void DiamondKing()
        {
            AssertCard(Card.Diamond.King, Suit.Diamond, Face.King, 3);
        }

        [Test]
        public void DiamondQueen()
        {
            AssertCard(Card.Diamond.Queen, Suit.Diamond, Face.Queen, 2);
        }

        [Test]
        public void DiamondEight()
        {
            AssertCard(Card.Diamond.Eight, Suit.Diamond, Face.Eight, 0);
        }

        [Test]
        public void DiamondSeven()
        {
            AssertCard(Card.Diamond.Seven, Suit.Diamond, Face.Seven, 0);
        }
        #endregion

        #region Club
        [Test]
        public void ClubJack()
        {
            AssertCard(Card.Club.Jack, Suit.Club, Face.Jack, 30);
        }

        [Test]
        public void ClubNine()
        {
            AssertCard(Card.Club.Nine, Suit.Club, Face.Nine, 20);
        }

        [Test]
        public void ClubAce()
        {
            AssertCard(Card.Club.Ace, Suit.Club, Face.Ace, 11);
        }

        [Test]
        public void ClubTen()
        {
            AssertCard(Card.Club.Ten, Suit.Club, Face.Ten, 10);
        }

        [Test]
        public void ClubKing()
        {
            AssertCard(Card.Club.King, Suit.Club, Face.King, 3);
        }

        [Test]
        public void ClubQueen()
        {
            AssertCard(Card.Club.Queen, Suit.Club, Face.Queen, 2);
        }

        [Test]
        public void ClubEight()
        {
            AssertCard(Card.Club.Eight, Suit.Club, Face.Eight, 0);
        }

        [Test]
        public void ClubSeven()
        {
            AssertCard(Card.Club.Seven, Suit.Club, Face.Seven, 0);
        }
        #endregion

        private static void AssertCard(Card card, Suit suit, Face face, int point)
        {
            Assert.AreEqual(suit, card.Suit);
            Assert.AreEqual(face, card.Face);
            Assert.AreEqual(point, card.Points);
        }
    }
}