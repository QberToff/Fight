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
        static public int Frames { get; set; } = 0;

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
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Frame: " + Frames);
                world.Update();
                
                int bigTeamCounter = 0;


                if (FirstTeam.Alive && SecondTeam.Alive)
                {
                    //определеяем команду с большим числом живых юнитов
                    if (FirstTeam.Counter > SecondTeam.Counter || FirstTeam.Counter == SecondTeam.Counter)
                    {
                        bigTeamCounter = FirstTeam.Counter;
                    }
                    else
                    {
                        bigTeamCounter = SecondTeam.Counter;
                    }

                    for (int i = 0; i < bigTeamCounter; i++)
                    {
                        coin = new Random().Next(0, 2); //рандом для того, кто будет бить, а кто получать удар
                        
                        Unit a = null;
                        Unit b = null;


                        if (/*coin == 0 &&*/ FirstTeam.PossibleToAttack) //бьёт юнит первой команды
                        {
                            a = FirstTeam.GetAttackerUnit();
                            b = SecondTeam.GetUnitFromTeam(new Random().Next(0, SecondTeam.Counter));
                        }
                        else if (/*coin == 1 &&*/ SecondTeam.PossibleToAttack) //бьёт юнит второй команды
                        {
                            a = SecondTeam.GetAttackerUnit();
                            b = FirstTeam.GetUnitFromTeam(new Random().Next(0, FirstTeam.Counter));
                        }

                        if (a != null && b != null) //проверяем выбраны ли юниты
                        {
                            undoredo.RegisterCommnad(new Attack(a, b)); 
                        }
                        
                        
                        //Console.WriteLine("         " + a.Name + " is ready for attack " + a.ReadyForAttack);
                        //Console.WriteLine("         " + b.Name + " is ready for attack " + b.ReadyForAttack);


                    }
                }
                else
                   isFighting = false;

                Frames++;
                //world.Update();
                //frames++;

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
