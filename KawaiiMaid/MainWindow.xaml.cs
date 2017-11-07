using System;
using System.Collections.Generic;
using System.Linq;
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

namespace KawaiiMaid
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            mainwindow.Topmost = true;
            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width;
            this.Top = desktopWorkingArea.Bottom - this.Height;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(@"F:\UIT\girl2\girl3\pose2\happy1.png"));
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(@"F:\UIT\GIT\KawaiiMaid\KawaiiMaid\Resources\serious.png"));
        }

        private void img_MouseMove(object sender, MouseEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(@"F:\UIT\GIT\KawaiiMaid\KawaiiMaid\Resources\seriousb.png"));
        }

        private void img_MouseDown(object sender, MouseButtonEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(@"F:\UIT\GIT\KawaiiMaid\KawaiiMaid\Resources\happy2b.png"));
        }

        private void img_MouseUp(object sender, MouseButtonEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(@"F:\UIT\GIT\KawaiiMaid\KawaiiMaid\Resources\happy2.png"));

        }



        private void MenuItem1_1_OnClick(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(@"F:\UIT\GIT\KawaiiMaid\KawaiiMaid\Resources\surprised1.png"));
        }

        private void MenuItem1_2_OnClick(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(@"F:\UIT\GIT\KawaiiMaid\KawaiiMaid\Resources\surprised1b.png"));
        }

        private void MenuItem1_3_OnClick(object sender, RoutedEventArgs e)
        {
            img.Source = new BitmapImage(new Uri(@"F:\UIT\GIT\KawaiiMaid\KawaiiMaid\Resources\surprised2b.png"));
        }
    }
}
