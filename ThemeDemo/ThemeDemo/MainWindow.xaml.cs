using System;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;

namespace ThemeDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationTheme.MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            UserName = Environment.UserName;
            ApplicationVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            this.NavigationService.LoadCompleted += NavigationService_LoadCompleted;

        }

        private void NavigationService_LoadCompleted(object sender, NavigationEventArgs e)
        {
            if (e.ExtraData != null)
            {
                // Do something here...
                System.Windows.MessageBox.Show(this,string.Format("Capture Page Skip Message:{0}",e.ExtraData),"Capture",MessageBoxButton.OK,MessageBoxImage.Information,MessageBoxResult.OK);
              
            }
        }

    }
}
