using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    public class Unit : IUnitHealth, IUnitAttackData, IUpdate
    {
        
       public string Name { get;  set; } 
        public int Damage { get; set; }
       
        public int Health { get; set; }

        public int AttackInterval { get; private set; } 

        public bool Alive { get; set; }

        public bool ReadyForAttack { get; set; } =  true;
        public bool HasHit { get; set; } = false;

        private int frames;
       

        public Unit (string name, int dam, int hlt, int interval)
        {
            Name = name;
            Damage = dam;
            Health = hlt;
            AttackInterval = interval;
            frames = 0;
            Alive = true;
            

        }
        public void Update()
        {
           
            if(frames == AttackInterval)
            {
                ReadyForAttack = true;
                frames = 0;
            }
            IsUnitDead();
            frames++;

        }

        public void LateUpdate()
        {
            //frames++;
        }
    
        
        public void UnitDescription()
        {
            Console.WriteLine("Unit Name " + Name);
            Console.WriteLine("Unit health " + Health);
            Console.WriteLine("Unit damage " + Damage);
        }
        
        private void IsUnitDead()
        {

            if (Health <= 0)
            {
                Alive = false;
                Console.WriteLine(Name + " is dead!");
            }

        }


    }
}
