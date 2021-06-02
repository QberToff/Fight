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
                //TODO 
            }
        }





    }
}
