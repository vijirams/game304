using System.Collections.Generic;
using System.Linq;

namespace Game304.Core
{
    public class Game
    {
        private readonly Player[] _players = new []
        {
            new Player(), 
            new Player(), 
            new Player(), 
            new Player()
        };

        private readonly IDeck _deck;

        private int _dealerPosition;

        public Game() : this(new Deck())
        {
        }

        public Game(IDeck deck)
        {
            _deck = deck;
            _dealerPosition = 0;
        }

        public Player[] Players
        {
            get { return _players; }
        }

        public IDeck Deck
        {
            get { return _deck; }
        }

        public void Start()
        {
            _deck.Shuffle();
            Deal();
        }

        private void Deal()
        {
            int i = 0;
            foreach (var player in PlayersInOrder())
            {
                player.Take(_deck.Cards.Skip(i * 4).Take(4).ToArray());
                i++;
            }
        }

        private IEnumerable<Player> PlayersInOrder()
        {
            for (int i = _dealerPosition + 1; i < _dealerPosition + _players.Length; i++)
            {
                int index = i != _players.Length ? i : i - _players.Length;
                yield return _players[index];
            }
        }
    }
}