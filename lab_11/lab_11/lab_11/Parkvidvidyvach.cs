using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11
{
    class Parkvidvidyvach
    {
        public bool PokatavsyanaGirkah { get; set; }
        public bool PostilyavvTire { get; set; }
        public bool ShodivVkimnatyStrahy { get; set; }
        public bool ShovivVkimnatyKrivDzerk { get; set; }
        public bool ziyvpopkorn { get; set; }
        public bool Pokatavsyanachortovomykolesi { get; set; }
        public void showInfo()
        {
            Console.WriteLine($"PokatavsyanaGirkah - {PokatavsyanaGirkah}");
            Console.WriteLine($"PostilyavvTire - {PostilyavvTire}");
            Console.WriteLine($"ShodivVkimnatyStrahy - {ShodivVkimnatyStrahy}");
            Console.WriteLine($"ShovivVkimnatyKrivDzerk - {ShovivVkimnatyKrivDzerk}");
            Console.WriteLine($"ziyvpopkorn - {ziyvpopkorn}");
            Console.WriteLine($"Pokatavsyanachortovomykolesi - {Pokatavsyanachortovomykolesi}");

        }
    }

}
