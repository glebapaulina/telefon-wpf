using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonWPF
{
    class Internet: Usluga
    {
        private int iloscMB;

        public override void ObliczCene()
        {
            cena = Math.Round((double)iloscMB / 756, 2);
        }

        public Internet(DateTime czas, int iloscMB): base(czas)
        {
            this.iloscMB = iloscMB;
            ObliczCene();
        }


        public override string ToString()
        {
            return string.Format("Internet, data i godzina: {0}, ilość MB: {1}, łączny koszt: {2}", czas, iloscMB, cena + Environment.NewLine);
        }
    }
}
