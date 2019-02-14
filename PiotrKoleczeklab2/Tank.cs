using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab1
{
    /// <summary>
    /// Jest to klasa przedstawiająca czołg
    /// </summary>
    class Tank
    {
        // zmienna potrzebna do określenia losowości zadawalnych uszkodzeń
        protected Random randDmg;
        // zmienna określająca liczbę punktów życia
        protected int Health { get; set; }
        // zmienna przechowująca jak wiele uszkodzeń może zadać czołg wrogowi
        protected int DamageCaused { get; private set; }

        // ustawienie zadawania uszkodzeń przez czołg
        protected void SetDamage(int lowerDmg, int upperDmg)
        {
            DamageCaused = randDmg.Next(lowerDmg, upperDmg);
        }

        // metoda zwracająca uszkodzenia zadawane przez czołg
        protected int GetDamage()
        {
            return DamageCaused;
        }
    }
}