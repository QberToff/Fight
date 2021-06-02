using System;
using System.Collections.Generic;
using System.Text;

namespace Fight
{
    class UndoRedoImplementation
    {

        Stack<Command> undo;
        Stack<Command> redo;

        public UndoRedoImplementation()
        {
             undo = new Stack<Command>();
             redo = new Stack<Command>();
        }

        public void RegisterCommnad(Command c)
        {
            redo.Clear();
            undo.Push(c);
            c.Apply();

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


    }
}
