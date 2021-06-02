using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    public class Team
    {
        public string Name { get; private set; }
        public int Counter { get; set; } = 0;
        private List<Unit> units = new List<Unit>();
        

        
        public void AddUnitToTeam(Unit unit)
        {
            units.Add(unit);
            Counter++;
        }

        public Unit GetUnitFromTeam(int index)
        {
            return units[index];
        }
            
    }
}
