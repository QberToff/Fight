using System;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit FirstUnit = new Unit("First", 20, 200, 5);
            Unit SecondUnit = new Unit("Second", 200, 200, 5);
            //FirstUnit.UnitDescription();
            //SecondUnit.UnitDescription();

            var u = new UndoRedoImplementation();
            u.RegisterCommnad(new Attack(SecondUnit, FirstUnit));
            //FirstUnit.IsUnitDead();
        }
    }
}
