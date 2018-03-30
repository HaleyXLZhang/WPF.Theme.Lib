using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace NavigationTheme
{
    public class MainWindow : NavigationWindow
    {

        static MainWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainWindow), new FrameworkPropertyMetadata(typeof(MainWindow)));
        }
        private PropertyChangedEventHandler PropertyChangedEvent;
        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                this.PropertyChangedEvent = (PropertyChangedEventHandler)Delegate.Combine(this.PropertyChangedEvent, value);
            }
            remove
            {
                this.PropertyChangedEvent = (PropertyChangedEventHandler)Delegate.Remove(this.PropertyChangedEvent, value);
            }
        }
        private ObservableCollection<MenuItem> _Menu;
        public ObservableCollection<MenuItem> Menu
        {
            get { return this._Menu; }
            set { this._Menu = value; }
        }
        public string UserName { get; set; }
        public string ApplicationVersion { get; set; }
        public string UserIconImageUrl { get; set; }
        public MainWindow()
        {
            UserName = Environment.UserName;
            this.AllowsTransparency = true;
            this.WindowStyle = WindowStyle.None;
            ApplicationVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonClicked));
            this.MouseMove += MainWindow_MouseMove;

            //User icon
            System.Windows.Controls.Image image = this.GetTemplateChild("ImageUrl") as System.Windows.Controls.Image;
            if (image != null && image.Visibility == Visibility.Visible)
            {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri("http://photos.global.hsbc/casual/square/" + Environment.UserName.Substring(0, 4) + "/" + Environment.UserName + ".jpg");
                bitmapImage.EndInit();
                image.Source = bitmapImage;
            }

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
            if ((e.OriginalSource as FrameworkElement).Name.Contains("closeButton")) { this.Close(); }
            if ((e.OriginalSource as FrameworkElement).Name.Contains("minimizeButton"))
            {
                this.WindowState = System.Windows.WindowState.Minimized;
            }
            if ((e.OriginalSource as FrameworkElement).Name.Contains("restoreButton"))
            {
                this.WindowState = (WindowState)((this.WindowState == WindowState.Normal) ? 2 : 0);
            }
        }
    }
}
