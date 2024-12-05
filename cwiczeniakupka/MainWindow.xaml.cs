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

namespace cwiczeniakupka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Obraz> obrazy = new List<Obraz>();
        int aktualny = 0;

        public MainWindow()
        {
            InitializeComponent();

            obrazy.Add(new Obraz("kaczucha.jpg"));
            obrazy.Add(new Obraz("kaczucha2.jpg"));
            obrazy.Add(new Obraz("kaczucha3.jpg"));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            aktualny--;
            if(aktualny < 0)
            {
                aktualny = obrazy.Count() - 1;
            }

            wyswietlObraz(aktualny);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            aktualny++;
            if (aktualny == obrazy.Count())
            {
                aktualny = 0;
            }

            wyswietlObraz(aktualny);
        }

        private void wyswietlObraz(int i)
        {
            image.Source = new BitmapImage(new Uri(obrazy[i].urlObrazka, UriKind.Relative));
            likes.Text = obrazy[i].liczbaPolubien.ToString() + " POLUBIEŃ";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            obrazy[aktualny].liczbaPolubien++;
            wyswietlObraz(aktualny);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int liczba = random.Next(obrazy.Count);

            wyswietlObraz(liczba);
        }
    }
}
