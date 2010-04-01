using Game304.Core;
using NUnit.Framework;

namespace Game304.UnitTests
{
    [TestFixture]
    public class PlayerTest
    {
        [Test]
        public void PlayerHasHand()
        {
            var player = new Player();
            Assert.IsNotNull(player.Hand);
        }

        [Test]
        public void TakeCards_AddToHand()
        {
            var player = new Player();
            player.Take(new [] {Card.Spade.Jack, Card.Spade.Nine, Card.Spade.Ace, Card.Spade.Ten});         
        }
    }
}