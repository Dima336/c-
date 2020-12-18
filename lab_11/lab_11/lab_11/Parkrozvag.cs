using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11
{
    class Parkrozvag
    {
        public virtual void IPokatavsyanaGirkah(Parkvidvidyvach kataus)
        {
            kataus.PokatavsyanaGirkah = true;
        }
        public virtual void IPostilyavvTire(Parkvidvidyvach kataus)
        {
            kataus.PostilyavvTire = true;
        }
        public virtual void IShodivVkimnatyStrahy(Parkvidvidyvach kataus)
        {
            kataus.ShodivVkimnatyStrahy = true;
        }
        public virtual void IShovivVkimnatyKrivDzerk(Parkvidvidyvach kataus)
        {
            kataus.ShovivVkimnatyKrivDzerk = true;
        }
        public virtual void Iziyvpopkorn(Parkvidvidyvach kataus)
        {
            kataus.ziyvpopkorn = true;
        }
        public virtual void IPokatavsyanachortovomykolesi(Parkvidvidyvach kataus)
        {
            kataus.Pokatavsyanachortovomykolesi = true;
        }
    }
}

