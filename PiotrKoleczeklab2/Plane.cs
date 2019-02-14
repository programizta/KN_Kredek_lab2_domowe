using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab1
{
    class Plane
    {
        // zmienna potrzebna do określenia losowości punktów życia samolotu
        protected Random randDmg;

        protected int damageCaused;
        protected int health;

        protected void SetDamage(int lowerDmg, int upperDmg)
        {
            damageCaused = randDmg.Next(lowerDmg, upperDmg);
        }

        protected int GetDamage()
        {
            return damageCaused;
        }
    }
}
