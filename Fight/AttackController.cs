using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    class AttackController
    {
        private UndoRedoImplementation undoredo;
        private Team FirstTeam;
        private Team SecondTeam;
        private World world;
        private int coin;

        public AttackController(UndoRedoImplementation undoredo, Team A, Team B, World world)
        {
            this.undoredo = undoredo;
            FirstTeam = A;
            SecondTeam = B;
            this.world = world;
        }

        public void ProcessFight()
        {
            bool isFighting = true;
            
            while (isFighting)
            {
                world.Update();
                coin = new Random().Next(0, 2);
                Unit a;
                Unit b;

                if (FirstTeam.Alive && SecondTeam.Alive)
                {
                    if (coin == 0)
                    {
                        a = FirstTeam.GetUnitFromTeam(new Random().Next(0, FirstTeam.Counter));
                        b = SecondTeam.GetUnitFromTeam(new Random().Next(0, SecondTeam.Counter));
                    }
                    else
                    {
                        a = SecondTeam.GetUnitFromTeam(new Random().Next(0, SecondTeam.Counter));
                        b = FirstTeam.GetUnitFromTeam(new Random().Next(0, FirstTeam.Counter));
                    }

                    undoredo.RegisterCommnad(new Attack(a, b));
                }
                else
                    isFighting = false;
                
                
            }
            Console.WriteLine("Fight ended!");

            if (!FirstTeam.Alive)
            {
                Console.WriteLine(SecondTeam.Name + " has won");
            }
            else
                Console.WriteLine(FirstTeam.Name + " has won");
        }





    }
}
