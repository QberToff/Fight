using System;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit FirstUnit = new Unit("First", 20, 200, 5);
            Unit SecondUnit = new Unit("Second", 20, 200, 5);
            Unit ThirdtUnit = new Unit("Third", 20, 200, 5);
            Unit FourthtUnit = new Unit("Fourth", 20, 200, 5);
            Team FirstTeam = new Team("A Team");
            Team SecondTeam = new Team("B Team");
            FirstTeam.AddUnitToTeam(FirstUnit);
            SecondTeam.AddUnitToTeam(SecondUnit);
            FirstTeam.AddUnitToTeam(ThirdtUnit);
            SecondTeam.AddUnitToTeam(FourthtUnit);
            World world = new World();
            world.AddElement(FirstTeam);
            world.AddElement(SecondTeam);
            var u = new UndoRedoImplementation();
            AttackController controller = new AttackController(u, FirstTeam, SecondTeam, world);
            controller.ProcessFight();



            Console.WriteLine("Enter frame: ");
            int frame;
            var input = Console.ReadKey();
            if(char.IsDigit(input.KeyChar))
            {
                frame = int.Parse(input.KeyChar.ToString());
            }
            else
            {
                frame = -1;
            }
            
            u.GetAttackByFrame(frame);

            //u.RegisterCommnad(new Attack(SecondUnit, FirstUnit));

        }
    }
}
