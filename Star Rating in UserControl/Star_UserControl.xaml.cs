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

namespace Star_Rating_in_UserControl
{
    /// <summary>
    /// Interaction logic for Star_UserControl.xaml
    /// </summary>
    public partial class Star_UserControl : UserControl
    {
        public Star_UserControl()
        {
            InitializeComponent();
        }

        string s = "Images/Star.png";
        string s2 = "Images/Empty Star.png";
        private void Image_S1_MouseDown(object sender, MouseButtonEventArgs e)
        {

            Image_S1.Source= new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
        }

        private void Image_S2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image_S1.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S2.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
        }

        private void Image_S3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image_S1.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S2.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S3.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
        }

        private void Image_S4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image_S1.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S2.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S3.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S4.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
        }

        private void Image_S5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image_S1.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S2.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S3.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S4.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
            Image_S5.Source = new BitmapImage(new Uri(s, UriKind.RelativeOrAbsolute));
        }

        private void Image_R_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image_S1.Source = new BitmapImage(new Uri(s2, UriKind.RelativeOrAbsolute));
            Image_S2.Source = new BitmapImage(new Uri(s2, UriKind.RelativeOrAbsolute));
            Image_S3.Source = new BitmapImage(new Uri(s2, UriKind.RelativeOrAbsolute));
            Image_S4.Source = new BitmapImage(new Uri(s2, UriKind.RelativeOrAbsolute));
            Image_S5.Source = new BitmapImage(new Uri(s2, UriKind.RelativeOrAbsolute));
        }
    }
}
