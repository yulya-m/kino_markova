using System.Windows;
using System.Windows.Controls;

namespace Kino26_Markova
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPage(new Pages.Clubs.Main());
        }
        public void OpenPage(Page page)
        {
            frame.Navigate(page);
        }

        private void Clubs(object sender, RoutedEventArgs e) =>
            OpenPage(new Pages.Clubs.Main());

        private void Users(object sender, RoutedEventArgs e) =>
            OpenPage(new Pages.Users.Main());
	}
}