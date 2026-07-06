using Kino26_Markova.Classes;
using System.Windows.Controls;

namespace Kino26_Markova.Pages.Users.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public ClubsContext AllClub = new ClubsContext();
        Main Main;
        Models.Users User;
        public Item(Models.Users User, Main Main)
        {
            InitializeComponent();
            this.FIO.Text = User.FIO;
            this.RentStart.Text = User.RentStart.ToString("yyyy-MM-dd");
            this.RentTime.Text = User.RentStart.ToString("HH:mm");
            this.Duration.Text = User.Duration.ToString();
            this.Club.Text = AllClub.Clubs.Where(x => x.Id == User.IdClub).First().Name;
            this.User = User;
            this.Main = Main;
        }

        private void EditUser(object sender, System.Windows.RoutedEventArgs e) =>
            MainWindow.init.OpenPage(new Add(Main, User));

        private void DeleteUser(object sender, System.Windows.RoutedEventArgs e)
        {
            Main.AllUsers.Users.Remove(User);
            Main.AllUsers.SaveChanges();
            Main.Parent.Children.Remove(this);
        }
    }
}
