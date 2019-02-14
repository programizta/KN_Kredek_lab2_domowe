using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab1
{
    class ReichTanks : Tank
    {
        public List<ReichTanks> reichTanks;

        public ReichTanks(int health)
        {
            this.Health = health;
        }

        public void CreateListOfTanks()
        {
            reichTanks = new List<ReichTanks>();
        }

        public void CreateTanks(int numOfTanks)
        {
            for (int i = 0; i < numOfTanks; i++)
            {
                reichTanks.Add(new ReichTanks(Health));
            }
        }

        public int GetCount()
        {
            return reichTanks.Count();
        }
    }
}
