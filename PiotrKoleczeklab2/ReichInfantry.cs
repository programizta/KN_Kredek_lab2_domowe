using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab1
{
    class ReichInfantry : Infantry
    {
        public List<ReichInfantry> platoons;
        public ReichInfantry(int numberOfPrivates)
        {
            this.numberOfPrivates = numberOfPrivates;
        }

        public void CreateListOfPlatoons()
        {
            platoons = new List<ReichInfantry>();
        }

        public void CreatePlatoons(int numOfPlatoons)
        {
            for(int i = 0; i < numOfPlatoons; i++)
            {
                platoons.Add(new ReichInfantry(numberOfPrivates));
            }
        }

        public int GetCount()
        {
            return platoons.Count();
        }
    }
}
