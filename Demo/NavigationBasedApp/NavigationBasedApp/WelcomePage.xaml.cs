using System.Windows;
using System.Windows.Controls;

namespace NavigationBasedApp
{
    /// <summary>
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Page
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void GoForwardButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoForward)
            {
                this.NavigationService.GoForward();
            }
            else
            {
                GreetingPage greeting = new GreetingPage();

                this.NavigationService.Navigate(greeting,"This is a test message.");

                //this.NavigationService.Navigate(new Uri("pack://application:,,,/GreetingPage.xaml"));
            }
        }
    }
}
