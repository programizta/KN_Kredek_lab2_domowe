using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab1
{
    class RussianInfantry : Infantry
    {
        public List<RussianInfantry> platoons;
        public RussianInfantry(int numberOfPrivates)
        {
            this.numberOfPrivates = numberOfPrivates;
        }

        public void CreateListOfPlatoons()
        {
            platoons = new List<RussianInfantry>();
        }

        public void CreatePlatoons(int numOfPlatoons)
        {
            for (int i = 0; i < numOfPlatoons; i++)
            {
                platoons.Add(new RussianInfantry(numberOfPrivates));
            }
        }

        public int GetCount()
        {
            return platoons.Count();
        }
    }
}
