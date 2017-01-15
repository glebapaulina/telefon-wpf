using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonWPF
{
    abstract class Usluga
    {
        protected DateTime czas;
        protected double cena;

        public abstract void ObliczCene();
        
        public Usluga(DateTime czas)
        {
            this.czas = czas;
        }
        


    }
}
