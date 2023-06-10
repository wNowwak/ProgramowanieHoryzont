using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium7
{
    internal class Osoba
    {
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }

        public Osoba(string? imie, string? nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
    }
}
