using VAP;

internal class Program
{
    private static void Main(string[] args)
    {
        BerthAllocationProblem problem = new BerthAllocationProblem();
        InstanceGenerator instanceGenerator = new InstanceGenerator();

        try
        {
            // Adding ships
            //problem.AddShip("Ship1", 2, 5, 1);
            //problem.AddShip("Ship2", 3, 6, 3);
            //problem.AddShip("Ship3", 4, 7, 2);
            //problem.AddShip("Ship4", 4, 7, 5);
            // Adding quays
            problem.AddQuay("Quay1", 10);
            //problem.AddQuay("Quay2", 2);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exception Message: " + ex.Message);
            Environment.FailFast("Application terminated due to exception");
        }

        // Allocating quays
        //problem.AllocateQuays();
        SimpleBerth simpleProblem = new SimpleBerth();
        simpleProblem.AddShip("Ship1", 2, 5, 1);
        simpleProblem.PrintShips();
        simpleProblem.AddShip("Ship2", 3, 6, 3);
        simpleProblem.PrintShips();
        simpleProblem.AddShip("Ship3", 4, 7, 2);
        simpleProblem.PrintShips();
        simpleProblem.AddQuay("Quay1", 10);
        simpleProblem.PrintQuays();
        List<Ship> ships = instanceGenerator.Generate();
        foreach (Ship ship in ships)
        {
            problem.AddShip(ship.Name, ship.ArrivalTime, ship.DepartureTime, ship.Size);
        }
    }
}
