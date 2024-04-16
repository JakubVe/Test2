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

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro Vytvořit.xaml
    /// </summary>
    public partial class Vytvořit : Window
    {
        private Zaměstnanec novyzam;
        public Vytvořit()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Jmeno = newjmeno.Text;
            string Prijmeni = newPrij.Text;
            int ID = int.Parse(newID.Text);
            DateTime Narozen = Datum.SelectedDate ?? DateTime.Now;

            novyzam = new Zaměstnanec(Jmeno, Prijmeni, ID, Narozen);
            this.Close();
        }
        public Zaměstnanec GetZaměstnanec()
        {
            return novyzam;
        }
    }
}
