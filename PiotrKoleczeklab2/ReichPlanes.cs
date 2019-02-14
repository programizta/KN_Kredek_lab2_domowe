using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab1
{
    class ReichPlanes : Plane
    {
        public List<ReichPlanes> reichPlanes;

        public ReichPlanes(int health)
        {
            this.health = health;
        }

        public void CreateListOfPlanes()
        {
            reichPlanes = new List<ReichPlanes>();
        }

        public void CreatePlanes(int numOfPlanes)
        {
            for (int i = 0; i < numOfPlanes; i++)
            {
                reichPlanes.Add(new ReichPlanes(health));
            }
        }

        public int GetCount()
        {
            return reichPlanes.Count();
        }
    }
}
