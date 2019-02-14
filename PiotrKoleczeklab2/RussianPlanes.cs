using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiotrKoleczeklab1
{
    class RussianPlanes : Plane
    {
        public List<RussianPlanes> russianPlanes;

        public RussianPlanes(int health)
        {
            this.health = health;
        }

        public void CreateListOfPlanes()
        {
            russianPlanes = new List<RussianPlanes>();
        }

        public void CreatePlanes(int numOfPlanes)
        {
            for (int i = 0; i < numOfPlanes; i++)
            {
                russianPlanes.Add(new RussianPlanes(health));
            }
        }

        public int GetCount()
        {
            return russianPlanes.Count();
        }
    }
}
