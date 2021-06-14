using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    public class Team : IUpdate
    {
        public string Name { get; set; }
        public int Counter { get; set; } = 0;
        public bool Alive { get; set; } = true;

        public bool PossibleToAttack { get; set; } = true;


        private List<Unit> units = new List<Unit>();
        
        public Team(string name)
        {
            Name = name;
        }

        
        public void AddUnitToTeam(Unit unit)
        {
            units.Add(unit);
            Counter++;
        }

        public Unit GetUnitFromTeam(int index)
        {
            return units[index];
        }

        public Unit GetAttackerUnit()
        {
            bool _mybool = true;
            Unit attacker = null;

            while (_mybool)
            {
                
                int rand = new Random().Next(0, units.Count);
                if (units[rand].ReadyForAttack)
                {

                    attacker = units[rand];
                    _mybool = false;
                   
                }
               
            }
            return attacker;
                

            
        }
                
        public void Update()
        {
            int index;
            for (int i = 0; i <= units.Count -1; i++)
            {
               
                units[i].Update();
               

                if (!units[i].ReadyForAttack)
                {
                    PossibleToAttack = false;
                }
                else
                {
                    PossibleToAttack = true;
                }

                if (!units[i].Alive)
                {
                    Counter--;
                    index = i;
                    units.RemoveAt(index);

                }


            }

            if(Counter <= 0)
            {
                Alive = false;
            }
                      
        }

        public void LateUpdate()
        {
            return;
        }
            
    }
}
