using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    class Player
    {
        private UndoRedoImplementation undoredo;
        Dictionary<int, List<Command>> allComands;
       
       
        

        public Player(UndoRedoImplementation undo)
        {
            this.undoredo = undo;
            allComands = undoredo.AllComands;
        }



        public void SwitchToFrame(int frame)
        {
            if(allComands.ContainsKey(frame))
            {
                List<Command> cc = new List<Command>();
                int key = -1;
                int i = allComands.Count - 1;
                var keys = allComands.Keys;
            
                while(key != frame)
                {

                    cc = allComands[i];
                    for (int j = 0; j <= cc.Count - 1; j++)
                    {
                        cc[j].Reset();


                        //REFACTOR???
                        foreach (KeyValuePair<int, List<Command>> pair in allComands)
                        {
                            if (pair.Value == cc)
                            {
                                key = pair.Key;
                            }
                            else
                                return;
                        }
                    }

                }

                AttackController.Frames = key;



            }
            else
            {
                Console.WriteLine("There is no such frame you want");
            }
            
           
        }







    }
}
