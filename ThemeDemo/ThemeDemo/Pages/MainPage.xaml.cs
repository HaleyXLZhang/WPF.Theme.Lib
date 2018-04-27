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

        private void FButton_Click_1(object sender, RoutedEventArgs e)
        {
            WaitingBox.Show(() =>
            {
                System.Threading.Thread.Sleep(13000);
            }, "正在玩命的加载，请稍后...");
            var res = MessageBoxX.Question("已经完了？");
        }
    }
}
