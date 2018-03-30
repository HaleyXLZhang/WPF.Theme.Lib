using System;
using System.Windows;
using System.Windows.Controls;

namespace ThemeDemo
{
    /// <summary>
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoForward)
            {
                this.NavigationService.GoForward();
            }
            else
            {
                this.NavigationService.Navigate(new Uri("Pages/ThirdPage.xaml", UriKind.Relative), "This is a SecondPage message.\r\n" + DateTime.Now);
            }
        }
    }
}
