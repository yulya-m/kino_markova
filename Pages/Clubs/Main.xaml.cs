using Kino26_Markova.Classes;
using System.Windows;
using System.Windows.Controls;

namespace Kino26_Markova.Pages.Clubs
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public ClubsContext AllClub = new ClubsContext();
        public Main()
        {
            InitializeComponent();
            foreach (Models.Clubs Club in AllClub.Clubs)
                Parent.Children.Add(new Elements.Item(Club, this));
        }

        private void AddClub(object sender, RoutedEventArgs e) =>
            MainWindow.init.OpenPage(new Add(this));
    }
}
