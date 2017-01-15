using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonWPF
{
    class Sms: Usluga
    {
        private string numer;

        public override void ObliczCene()
        {
            cena = 0.15;
        }

        public Sms(DateTime czas, string numer):base(czas)
        {
            this.numer = numer;
            ObliczCene();
        }

        public override string ToString()
        {
            return string.Format("Sms: numer {0}, data i godzina smsa: {1}, łączny koszt: {2}", numer, czas, cena + Environment.NewLine);
        }
    }
}
