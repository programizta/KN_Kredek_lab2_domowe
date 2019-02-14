using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab1
{
    /// <summary>
    /// Klasa określająca jednostki piechoty
    /// </summary>
    class Infantry
    {
        // zmienna określająca liczbę żołnierzy w jednostce
        protected int numberOfPrivates;
        // zmienna potrzebna do określenia losowości zadawalnych uszkodzeń
        Random randDmg;
        // zmienna określająca liczbę jednostek
        protected int numberOfPlatoons;
        // metoda określająca jak wiele żołnierzy zostaje zabitych
        protected void SetKills(int lowerDmg, int upperDmg)
        {
            numberOfPrivates = randDmg.Next(lowerDmg, upperDmg);
        }

        // metoda zwracająca liczbę żołnierzy
        protected int GetNumOfPrivates()
        {
            return numberOfPrivates;
        }
    }
}

