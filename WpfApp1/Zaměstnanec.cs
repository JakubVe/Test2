using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Zaměstnanec
    {
        public Zaměstnanec(string jmeno, string prijmeni, int iD, DateTime narozen)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            ID = iD;
            Narozen = narozen;
        }

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int ID { get; set; }
        public DateTime Narozen {get; set; }

        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} {ID} {Narozen.ToShortDateString()}";
        }
    }
    

    
}
