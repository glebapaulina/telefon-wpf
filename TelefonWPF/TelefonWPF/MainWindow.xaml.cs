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

namespace TelefonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Telefon telefon = new Telefon();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void polaczenie_Click(object sender, RoutedEventArgs e)
        {
            GridPolaczenie.Visibility = Visibility.Visible;
            DisableButtons();
            Clear();
        }

        private void dodajpolaczenie_Click(object sender, RoutedEventArgs e)
        {
            int czas;
            if (string.IsNullOrEmpty(numerpolaczenie.Text) == false && int.TryParse(czaspolaczenia.Text, out czas ) == true)
            {
                telefon.DodajPolaczenie(numerpolaczenie.Text, Convert.ToInt16(czaspolaczenia.Text));
                biling.Text = telefon.ToString();
                GridPolaczenie.Visibility = Visibility.Hidden;
                EnableButtons();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane.");
            }

        }

        private void sms_Click(object sender, RoutedEventArgs e)
        {
            GridSms.Visibility = Visibility.Visible;
            Clear();
            DisableButtons();
        }

        private void dodajsms_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (numersms.Text.Length != 0)
                {
                    telefon.DodajSms(numersms.Text);
                    biling.Text = telefon.ToString();
                    GridSms.Visibility = Visibility.Hidden;
                    EnableButtons();

                }
            }
            catch
            {
                MessageBox.Show("Nieprawidłowe dane.");
            }

        }

        private void internet_Click(object sender, RoutedEventArgs e)
        {
            GridInternet.Visibility = Visibility.Visible;
            Clear();
            DisableButtons();
        }
        private void dodajinternet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(iloscmb.Text) > 0)
                {
                    telefon.DodajInternet(Convert.ToInt16(iloscmb.Text));
                    biling.Text = telefon.ToString();
                    GridInternet.Visibility = Visibility.Hidden;
                    EnableButtons();

                }
            }
            catch
            {
                MessageBox.Show("Nieprawidłowe dane.");
            }

        }


        private void DisableButtons()
        {
            polaczenie.IsEnabled = false;
            sms.IsEnabled = false;
            internet.IsEnabled = false;
        }
        private void EnableButtons()
        {
            polaczenie.IsEnabled = true;
            sms.IsEnabled = true;
            internet.IsEnabled = true;
        }
        private void Clear()
        {
            czaspolaczenia.Clear();
            numerpolaczenie.Clear();
            numersms.Clear();
            iloscmb.Clear();
        }

        private void zapisz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                telefon.ZapiszBiling();
                MessageBox.Show("Zapisano biling!");
            }
            catch
            {
                MessageBox.Show("Nie udało się zapisać bilingu");
            }
        }
    }
}
