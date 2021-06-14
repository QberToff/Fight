using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    public abstract class Command
    {
        public abstract void Apply();
        public abstract void Reset();
        
        
        

    }


    public class Attack : Command
    {
        IUnitHealth Health;
        IUnitAttackData Attacker;
        
        public Attack(IUnitAttackData attackData, IUnitHealth health)
        {
            Attacker = attackData;
            Health = health;
        }
        public override void Apply()
        {
            Attacker.ReadyForAttack = false;
            Health.Health -= Attacker.Damage;            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     " + "Unit " + Attacker.Name  + " attacked unit " + Health.Name );

            
            
            
        }

        public override void Reset()
        {
           Health.Health += Attacker.Damage;
            Attacker.ReadyForAttack = true;
        }

       
    }
}
