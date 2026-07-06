using Kino26_Markova.Classes;
using System.Windows;
using System.Windows.Controls;

namespace Kino26_Markova.Pages.Users
{
	/// <summary>
	/// Логика взаимодействия для Main.xaml
	/// </summary>
	public partial class Main : Page
    {
        public UserContext AllUsers = new UserContext();
        public Main()
        {
            InitializeComponent();
            foreach (Models.Users User in AllUsers.Users)
                Parent.Children.Add(new Elements.Item(User, this));
        }

        private void AddUser(object sender, RoutedEventArgs e) =>
            MainWindow.init.OpenPage(new Add(this));
    }
}
