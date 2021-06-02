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

        public AttackController(UndoRedoImplementation undoredo, Team A, Team B)
        {
            this.undoredo = undoredo;
            FirstTeam = A;
            SecondTeam = B;
        }

        public void ProcessFight()
        {
            while (FirstTeam.Counter > 0 || SecondTeam.Counter > 0)
            {
                var coin = new Random().Next(0, 1);
                Unit a;
                Unit b;

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

                undoredo.RegisterCommnad(new Attack(a,b));
            }
        }





    }
}
