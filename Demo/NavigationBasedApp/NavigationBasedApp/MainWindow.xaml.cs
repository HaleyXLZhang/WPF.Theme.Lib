using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace NavigationBasedApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public string UserName { get; set; }
        public string ApplicationVersion { get; set; }
        public MainWindow()
        {
            UserName = Environment.UserName;
            ApplicationVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            InitializeComponent();
            RootWindow.AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonClicked));       
        }
        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            if ((e.OriginalSource as FrameworkElement).Name.Contains("close")) { this.Close(); }
            if ((e.OriginalSource as FrameworkElement).Name.Contains("min"))
            {
                this.WindowState = System.Windows.WindowState.Minimized;
                this.WindowStyle = System.Windows.WindowStyle.None;
            }
            if ((e.OriginalSource as FrameworkElement).Name.Contains("restore"))
            {
                if (this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = System.Windows.WindowState.Normal;
                    this.WindowStyle = System.Windows.WindowStyle.None;
                }
                else
                {
                    this.WindowState = System.Windows.WindowState.Maximized;
                    this.WindowStyle = System.Windows.WindowStyle.None;
                }
            }
        }
        private void window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }     
    }
}
