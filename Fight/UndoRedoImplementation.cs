using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    class UndoRedoImplementation
    {

        Stack<Command> undo;
        Stack<Command> redo;
        public Dictionary<int, List<Command>> AllComands { get; set; }

        public UndoRedoImplementation()
        {
             undo = new Stack<Command>();
             redo = new Stack<Command>();
            AllComands = new Dictionary<int, List<Command>>();
        }

        public void RegisterCommnad(Command c/*, int key*/)
        {
            redo.Clear();
            undo.Push(c);
            c.Apply();


           
            //allComands.Add(key, c);

        }

        public void Undo()
        {
            if (undo.Count == 0)
                return;
            var c = undo.Pop();
            c.Reset();
            redo.Push(c);
        }

        public void Redo()
        {
            if (redo.Count == 0)
                return;

            var c = redo.Pop();
            c.Apply();
            undo.Push(c);
        }
        

        public void AddToAllCommands(Command c, int key)
        {

            if (AllComands.ContainsKey(key))
            {

                List<Command> cc;
                AllComands.TryGetValue(key, out cc);
                cc.Add(c);
            }
            else
            {
                List<Command> cc = new List<Command>();
                cc.Add(c);
                AllComands.Add(key, cc);
            }
        }

        public void GetAttackByFrame(int frame)
        {
            List<Command> cc;
            AllComands.TryGetValue(frame, out cc);
            
            for (int i = 0; i <= cc.Count - 1; i++)
            {
                
                cc[i].Apply();

            }
            
        }


    }
}
