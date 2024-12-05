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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(obrazeczki.SelectedIndex == 0)
            {
                image3.Source = new BitmapImage(new Uri("kaczucha.jpg", UriKind.Relative));
            }
            else if (obrazeczki.SelectedIndex == 1)
            {
                image3.Source = new BitmapImage(new Uri("kaczucha2.jpg", UriKind.Relative));
            }
            else if (obrazeczki.SelectedIndex == 2)
            {
                image3.Source = new BitmapImage(new Uri("kaczucha3.jpg", UriKind.Relative));
            }
        }
    }
}
