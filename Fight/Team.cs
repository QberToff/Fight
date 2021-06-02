using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    public class Team
    {
        public string Name { get; private set; }
        private List<Unit> units = new List<Unit>();
        

        
        public void AddUnitToTeam(Unit unit)
        {
            units.Add(unit);
        }

        public Unit GetUnitFromTeam(int index)
        {
            return units[index];
        }
            
    }
}
