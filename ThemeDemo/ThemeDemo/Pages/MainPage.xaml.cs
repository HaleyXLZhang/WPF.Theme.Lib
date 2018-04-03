using NavigationTheme;
using System;
using System.Windows;
using System.Windows.Controls;
using ThemeDemo.Popup;

namespace ThemeDemo
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
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
                this.NavigationService.Navigate(new Uri("Pages/SecondPage.xaml", UriKind.Relative), "This is a MainPage message.\r\n" + DateTime.Now);
            }
        }

        private void FButton_Click(object sender, RoutedEventArgs e)
        {
            PopupTemplate win = new PopupTemplate();
            win.PopupContext.Source = new Uri("../Popup/Pages/MainPagePopup.xaml", UriKind.Relative);
            win.ShowDialog();
        }

       
    }
}
