using System.Windows;
using TMS.Views;
namespace TMS.Views
{
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void Info_OnClick(object sender, RoutedEventArgs e)
        {
            InfoScreen infoWindow = new InfoScreen();
            infoWindow.ShowDialog();
        }

        private void LogIn_OnClick(object sender, RoutedEventArgs e)
        {
            //TODO: Log in
        }
    }
}