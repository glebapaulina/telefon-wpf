using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TelefonWPF
{
    class Telefon : IDodaj, IBiling
    {
        private List<Usluga> biling = new List<Usluga>();

        public void DodajPolaczenie(string numer, int czasP)
        {
            biling.Add(new Polaczenie(DateTime.Now, numer, czasP));
        }

        public void DodajSms(string numer)
        {
            biling.Add(new Sms(DateTime.Now, numer));
        }

        public void DodajInternet(int iloscMB)
        {
            biling.Add(new Internet(DateTime.Now, iloscMB));
        }

        public override string ToString()
        {
            string result = "";
            foreach (var element in biling)
            {
                result += element.ToString() + Environment.NewLine;
            }
            return result;
        }

        public void ZapiszBiling()
        {           
            using (StreamWriter sw = new StreamWriter("biling.txt"))
            {
                sw.Write(ToString());
            }
        }
    }
}


