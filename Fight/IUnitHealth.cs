using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    public interface IUnitHealth
    {
        public int Health { get; set; }

        public string Name { get; set; }

        public bool HasHit { get; set; }

    }

    public interface IUnitAttackData
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public bool ReadyForAttack { get; set; }

    }

}
