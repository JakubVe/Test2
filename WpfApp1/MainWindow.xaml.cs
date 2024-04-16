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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Zaměstnanec>
            zamestnanci = new List<Zaměstnanec>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vytvořit novy = new Vytvořit();
            novy.ShowDialog();

            Zaměstnanec novyzam = novy.GetZaměstnanec();

            if (novyzam != null)
            {
                zamestnanci.Add(novyzam);

                Obnovit();
            }
        }

        private void Obnovit()
        {
            List.Items.Clear();
            foreach (Zaměstnanec zaměstnanec in zamestnanci)
            {
                List.Items.Add(zaměstnanec);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem != null)
            {
                zamestnanci.Remove((Zaměstnanec)List.SelectedItem);
                Obnovit();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem != null)
            {
                Zaměstnanec vybran = (Zaměstnanec)List.SelectedItem;

                Edit edit = new Edit(vybran);
                edit.ShowDialog();

                Zaměstnanec editzam = edit.GetEdit();

                if(editzam != null)
                {
                    int index = zamestnanci.IndexOf(editzam);
                    zamestnanci[index] = editzam;
                    Obnovit();
                }
            }
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List.SelectedItem != null)
            {
                Zaměstnanec vybran = (Zaměstnanec)List.SelectedItem;
                MessageBox.Show($"Jmeno:{vybran.Jmeno}\n" +
                    $"Příjmení:{vybran.Prijmeni}\n" +
                    $"ID:{vybran.ID}\n" +
                    $"Narození:{vybran.Narozen.ToShortDateString()}");
            }
        }
    }
}
