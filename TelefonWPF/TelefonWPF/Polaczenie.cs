using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonWPF
{
    class Polaczenie : Usluga
    {
        private string numer;
        private int czasP;

        public override void ObliczCene()
        {
            cena = czasP * 0.29;
        }

        public Polaczenie(DateTime czas, string numer, int czasP) : base(czas)
        {
            this.numer = numer;
            this.czasP = czasP;
            ObliczCene();
        }



        public override string ToString()
        {
            return string.Format("Połączenie: numer {0}, data i godzina rozmowy: {1}, długość trwania: {2}, łączny koszt: {3}", numer, czas, czasP, cena + Environment.NewLine);
        }




    }
}
