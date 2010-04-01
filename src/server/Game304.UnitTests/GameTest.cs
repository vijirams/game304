using Game304.Core;
using NUnit.Framework;
using Rhino.Mocks;

namespace Game304.UnitTests
{
    [TestFixture]
    public class GameTest
    {
        private Game _game; 
        private IDeck _deck;

        private Card[] _cards;

        [Test]
        public void GameHas4Players()
        {
            Assert.AreEqual(4, _game.Players.Length);
        }

        [Test]
        public void GameHasDeckOfCards()
        {
            Assert.IsNotNull(_game.Deck);
        }

        [Test]
        public void Start_ShuffleCards()
        {
            _game.Start();
            _deck.AssertWasCalled(d => d.Shuffle());
        }

        [Test]
        public void Start_DealCards()
        {
            _game.Start();

            Assert.IsTrue(_game.Players[1].Has(Card.Heart.Jack, Card.Heart.Nine, Card.Heart.Ace, Card.Heart.Ten));
            Assert.IsTrue(_game.Players[2].Has(Card.Heart.King, Card.Heart.Queen, Card.Heart.Eight, Card.Heart.Seven));
            Assert.IsTrue(_game.Players[3].Has(Card.Diamond.Jack, Card.Diamond.Nine, Card.Diamond.Ace, Card.Diamond.Ten));
            Assert.IsTrue(_game.Players[0].Has(Card.Diamond.King, Card.Diamond.Queen, Card.Diamond.Eight, Card.Diamond.Seven));
            //Assert.IsTrue(_game.Players[0].Has(Card.Heart.Jack, Card.Heart.Nine, Card.Heart.Ace, Card.Heart.Ten));
        }
        
        [SetUp]
        public void SetUp()
        {
            _deck = MockRepository.GenerateStub<IDeck>();
            
            _game = new Game(_deck);

            _cards = new []
             {
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
                 Card.Club.Seven,
                 Card.Spade.Jack,
                 Card.Spade.Nine,
                 Card.Spade.Ace,
                 Card.Spade.Ten,
                 Card.Spade.King,
                 Card.Spade.Queen,
                 Card.Spade.Eight,
                 Card.Spade.Seven
             };

            _deck.Stub(d => d.Cards).Return(_cards);
        }
    }
}