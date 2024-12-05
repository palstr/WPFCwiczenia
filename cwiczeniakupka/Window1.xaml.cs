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
using System.Windows.Shapes;

namespace cwiczeniakupka
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Obraz> obrazy3 = new List<Obraz>();

        public Window1()
        {
            InitializeComponent();
            obrazy3.Add(new Obraz("kaczucha.jpg"));
            obrazy3.Add(new Obraz("kaczucha2.jpg"));
            obrazy3.Add(new Obraz("kaczucha3.jpg"));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(kaczka1.IsChecked == true)
            {
                image2.Source = new BitmapImage(new Uri(obrazy3[0].urlObrazka, UriKind.Relative));
                msg.Text = "";
            }
            else if(kaczka2.IsChecked == true)
            {
                image2.Source = new BitmapImage(new Uri(obrazy3[1].urlObrazka, UriKind.Relative));
                msg.Text = "";
            }
            else if(kaczka3.IsChecked == true)
            {
                image2.Source = new BitmapImage(new Uri(obrazy3[2].urlObrazka, UriKind.Relative));
                msg.Text = "";
            }
            else
            {
                msg.Text = "ZAZNACZ COŚ";
            }
        }
    }
}
