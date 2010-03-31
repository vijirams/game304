using System.Windows;

namespace Game304.Client
{
    public partial class Shell 
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void StartGameOnClick(object sender, RoutedEventArgs e)
        {
            _gameTable.StartGame();
        }
    }
}
