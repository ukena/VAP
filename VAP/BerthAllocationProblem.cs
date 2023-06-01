/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BerthAllocationProblem
{
    private List<Ship> ships;
    private List<Berth> berths;

    public BerthAllocationProblem()
    {
        ships = new List<Ship>();
        berths = new List<Berth>();
    }

    public void AddShip(string name, int arrivalTime, int departureTime)
    {
        Ship ship = new Ship(name, arrivalTime, departureTime);
        ships.Add(ship);
    }

    public void AddBerth(string name, int capacity)
    {
        Berth berth = new Berth(name, capacity);
        berths.Add(berth);
    }

    public void AllocateBerths()
    {
        ships.Sort((x, y) => x.ArrivalTime.CompareTo(y.ArrivalTime));

        foreach (Ship ship in ships)
        {
            bool berthAllocated = false;

            foreach (Berth berth in berths)
            {
                if (berth.Capacity > 0 && ship.ArrivalTime >= berth.Capacity)
                {
                    Console.WriteLine($"Ship {ship.Name} allocated to Berth {berth.Name}");
                    berth.Capacity--;
                    berthAllocated = true;
                    break;
                }
            }

            if (!berthAllocated)
            {
                Console.WriteLine($"No berth available for Ship {ship.Name}");
            }
        }
    }
}
*/