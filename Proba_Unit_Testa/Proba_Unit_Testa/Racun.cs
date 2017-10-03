using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba_Unit_Testa
{
    public class Racun
    {
        public double Stanje { private set; get; }

        public Racun()
        {
            Stanje = 0;
        }

        public Racun(double pocetnoStanje)
        {
            Stanje = pocetnoStanje;
        }

        public bool UplatiNovacNaRacun(double iznos)
        {
            if (iznos < 0)
                return false;

            Stanje += iznos;
            return true;
        }

        public bool SkiniNovacSaRacuna(double iznos)
        {
            if (iznos < 0)
                return false;
            //ovde je inace stojalo (iznos < Stanje) i trebalo mi je pola sata da skontam !
            if (iznos > Stanje)
                return false;

            Stanje -= iznos;
            return true;
        }
    }
}
