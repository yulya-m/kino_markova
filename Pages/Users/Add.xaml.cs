using Kino26_Markova.Classes;
using System.Windows.Controls;
using System;
using System.Linq;

namespace Kino26_Markova.Pages.Users
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Page
    {
        public Main Main;
        public Models.Users User;
        public ClubsContext AllClub = new ClubsContext();
        public Add(Main Main, Models.Users User = null)
        {
            InitializeComponent();
            this.Main = Main;
            foreach (Models.Clubs Club in AllClub.Clubs)
                Clubs.Items.Add(Club.Name);
            Clubs.Items.Add("Выберите..");
            if (User != null)
            {
                this.User = User;
                this.FIO.Text = User.FIO;
                this.RentStart.Text = User.RentStart.ToString("yyyy-MM-dd");
                this.RentTime.Text = User.RentStart.ToString("HH:mm");
                this.Duration.Text = User.Duration.ToString();
                Clubs.SelectedItem = AllClub.Clubs.Where(x => x.Id == User.IdClub).First().Name;
                BthAdd.Content = "Изменить";
            }
        }
		private void AddUser(object sender, System.Windows.RoutedEventArgs e)
		{
            DateTime DTRentStart = new DateTime();
            DateTime.TryParse(this.RentStart.Text, out DTRentStart);
            DTRentStart = DTRentStart.Add(TimeSpan.Parse(this.RentTime.Text));
            if(this.User == null)
            {
                User = new Models.Users();
                User.FIO = this.FIO.Text;
                User.RentStart = DTRentStart;
                User.Duration = Convert.ToInt32(this.Duration.Text);
                User.IdClub = AllClub.Clubs.Where(x => x.Name == Clubs.SelectedItem).First().Id;
                this.Main.AllUsers.Users.Add(this.User);
            }
            else
            {
                User.FIO = this.FIO.Text;
                User.RentStart = DTRentStart;
                User.Duration = Convert.ToInt32(this.Duration.Text);
                User.IdClub = AllClub.Clubs.Where(x => x.Name == Clubs.SelectedItem).First().Id;
            }
            this.Main.AllUsers.SaveChanges();
            MainWindow.init.OpenPage(new Main());
		}
	}
}
