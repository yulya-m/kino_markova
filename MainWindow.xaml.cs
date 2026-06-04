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
        }
        public void OpenPage(Page page)
        {
            frame.Navigate(page);
        }
    }
}