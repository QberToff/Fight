using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    class World
    {
        private List<Unit> worldUnits = new List<Unit>();

        public void AddUnit(Unit unit)
        {
            worldUnits.Add(unit);
        }

        public void Update()
        {

            while (true)
            {
                foreach (var un in worldUnits)
                {
                    un.Update();
                }
            }

            
            
        }



    }
}
