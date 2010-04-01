using System.Linq;
using Game304.Core;

namespace Game304.UnitTests
{
    public static class TestExtensions
    {
        public static bool Has(this Player player, params Card[] cards)
        {
            return cards.All(card => player.Hand.Cards.Contains(card));
        }
    }
}