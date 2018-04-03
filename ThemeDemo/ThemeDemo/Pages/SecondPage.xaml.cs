using System;
using System.Utility;
using System.Windows;
using System.Windows.Controls;

namespace ThemeDemo
{
    /// <summary>
    /// Interaction logic for SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        private IAsynNotify Asyn;
        public SecondPage()
        {
            InitializeComponent();
            this.Asyn = new DefaultAsynNotify();
            this.pro4.DataContext = this.Asyn;
            
            
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

        private void FButton_Click(object sender, RoutedEventArgs e)
        {
            System.Utility.SingleThread _Thread;
            _Thread = new SingleThread();
            this.Asyn.Start(100);
            _Thread.Start(() =>
            {
                for (int i = 0; i < 100; i += 1)
                {
                    this.Asyn.Advance(1);
                    System.Threading.Thread.Sleep(50);
                }
                this.Asyn.IsSuccess = true;
            });
        }
    }
}
