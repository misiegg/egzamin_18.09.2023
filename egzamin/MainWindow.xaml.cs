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

namespace egzamin
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            stanowiskoEntry.ItemsSource = combobox;
        }

        string haslo = "";



        List<String> combobox = new List<String>() {
        "kierownik","młodszy programista","starszy programista","tester"}
        ;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string liczby = "0123456789";
            string litery = "qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM";
            string specjalne = "!@#$%^&*()_+-=";
            string input = "";

            if (literyTick.IsChecked == true)
                input += litery;
            if (liczbyTick.IsChecked == true)
                input += liczby;
            if (specjalneTick.IsChecked == true)
                input += specjalne;

            Random rnd = new Random();
            for (int i = 0; i < int.Parse(dlugoscEntry.Text); i++)
            {
                haslo += input[rnd.Next(0, input.Count()-1)];
            }

            MessageBox.Show(haslo);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {imieEntry.Text} {nazwiskoEntry.Text} {combobox[stanowiskoEntry.SelectedIndex]} Hasło: {haslo}");
        }
    }
}
