using System;
using System.Windows;
using System.Windows.Controls;

namespace ThemeDemo
{
    /// <summary>
    /// Interaction logic for ThirdPage.xaml
    /// </summary>
    public partial class ThirdPage : Page
    {
        public ThirdPage()
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
                this.NavigationService.Navigate(new Uri("Pages/MainPage.xaml", UriKind.Relative), "This is a ThirdPage message.\r\n" + DateTime.Now);
            }
        }
    }
}
