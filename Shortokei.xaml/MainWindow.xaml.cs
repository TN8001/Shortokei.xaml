using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Shortokei.xaml
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Window_ContentRendered(object sender, EventArgs e)
            => myStoryboard.Seek(myRectangle, DateTime.Now - DateTime.Now.Date, TimeSeekOrigin.BeginTime);
    }
}
