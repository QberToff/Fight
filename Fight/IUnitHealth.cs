using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    public interface IUnitHealth
    {
        public int Health { get; set; }


    }

    public interface IUnitAttackData
    {        
        public int Damage { get; set; }

        public bool ReadyForAttack { get; set; }

    }

}
