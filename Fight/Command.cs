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
            if(Attacker.ReadyForAttack)
            {
                Health.Health -= Attacker.Damage;
                Attacker.ReadyForAttack = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("     " + "Unit " + Attacker.Name  + " attacked unit " + Health.Name );
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("     " + "Unit " + Attacker.Name + " can't attack");
            }
            
            
        }

        public override void Reset()
        {
           Health.Health += Attacker.Damage;
            Attacker.ReadyForAttack = true;
        }

       
    }
}
