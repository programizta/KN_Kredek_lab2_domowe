using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab1
{
    class RussianTanks : Tank
    {
        public List<RussianTanks> russianTanks;

        public RussianTanks(int health)
        {
            this.Health = health;
        }

        public void CreateListOfTanks()
        {
            russianTanks = new List<RussianTanks>();
        }

        public void CreateTanks(int numOfTanks)
        {
            for (int i = 0; i < numOfTanks; i++)
            {
                russianTanks.Add(new RussianTanks(Health));
            }
        }

        public int GetCount()
        {
            return russianTanks.Count();
        }
    }
}
