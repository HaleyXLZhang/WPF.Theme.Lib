using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
                MessageBox.Show(string.Format("Capture Page Skip Message:{0}",e.ExtraData));
            }
        }

    }
}
