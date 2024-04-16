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
    /// Interakční logika pro Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        private Zaměstnanec editzam;
        public Edit(Zaměstnanec zaměstnanec)
        {
            InitializeComponent();
            editJmeno.Text = zaměstnanec.Jmeno;
            editPrij.Text = zaměstnanec.Prijmeni;
            editID.Text = zaměstnanec.ID.ToString();
            editNaroz.SelectedDate = zaměstnanec.Narozen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Jmeno = editJmeno.Text;
            string Prijemni = editPrij.Text;
            int ID = int.Parse(editID.Text);
            DateTime Narozen = editNaroz.SelectedDate ?? DateTime.Now;

            editzam = new Zaměstnanec(Jmeno, Prijemni,ID,Narozen);
            this.Close();
        }
        public Zaměstnanec GetEdit()
        {
            return editzam;
        }


    }
}
