using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace NavigationTheme
{
    public class MainWindow : NavigationWindow
    {
        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }
        public string UserName { get; set; }
        public string ApplicationVersion { get; set; }
        public string UserIconImageUrl { get; set; }
        public MainWindow()
        {
            UserName = Environment.UserName;
            ApplicationVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonClicked));
            this.MouseMove += MainWindow_MouseMove;
           
        }
        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
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
    }
}
