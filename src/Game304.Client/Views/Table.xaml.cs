using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game304.Client.Views
{
    public partial class Table 
    {

        private int dealer = 0;

        public int[] Cards = new []
        {
            1, 2, 3, 4, 5, 6, 7, 8,
            9, 10, 11, 12, 13, 14, 15, 16,
            17, 18, 19, 20, 21, 22, 23, 24,
            25, 26, 27, 28, 29, 30, 31, 32
        };

        public string[] FaceTable = new[]
        {
            "J", "9", "A", "10", "K", "Q", "8", "7"
        };

        public string[] SuitTable = new[]
        {
            "Spade", "Heart", "Diamond", "Club"
        };

        public string[] DealerTable = new[]
        {
            "North", "West", "South", "East"
        };

        public Table()
        {
            InitializeComponent();
        }

        public void StartGame()
        {
            Shuffle();
            _northText.Text = "xxxxx";
            _westText.Text = "xxxxx";
            _eastText.Text = "xxxxx";

            int toSkip = dealer == 0 ? 1 :
                         dealer == 1 ? 0 :
                         dealer == 2 ? 3 :
                         dealer == 3 ? 2 : 0;

            _sourthText.Text = DisplayCardsInText(Cards.Skip(toSkip * 4).Take(4));

            if (dealer != 2)
            {
                Bid();
            }

            dealer++;
            if (dealer == 4)
            {
                dealer = 0;
            }
        }

        private void Bid()
        {
            _message.Text = DealerTable[dealer] + ": " + "Pass!";
        }

        //private int[] GetCards(int player)
        //{
            
        //}

        private string DisplayCardsInText(IEnumerable<int> cards)
        {
            var sb = new StringBuilder();
            foreach (var card in cards)
            {
                sb.AppendLine(GetCardString(card));
            }
            return sb.ToString();
        }

        private string GetCardString(int card)
        {
            int suitIndxe = card/8;
            int faceIndex = card%8;
            return SuitTable[suitIndxe] + " " + FaceTable[faceIndex];
        }

        private void Shuffle()
        {
            for (int i = 0; i < Cards.Length; i++)
            {
                var random = i + new Random().Next(Cards.Length - i);
                Swap(i, random);
            }
        }

        private void Swap(int from, int to)
        {
            int temp = Cards[from];
            Cards[from] = Cards[to];
            Cards[to] = temp;
        }
    }
}
