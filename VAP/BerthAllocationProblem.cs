using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BerthAllocationProblem
{
    protected List<Ship> ships;
    protected List<Quay> quays;

    public BerthAllocationProblem()
    {
        ships = new List<Ship>();
        quays = new List<Quay>();
    }

    public virtual void AddShip(string name, int arrivalTime, int departureTime, int size)
    {
        Ship ship = new Ship(name, arrivalTime, departureTime, size);
        ships.Add(ship);
    }

    public virtual void AddQuay(string name, int capacity)
    {
        Quay berth = new Quay(name, capacity);
        quays.Add(berth);
    }

    public void AllocateQuays()
    {
        ships.Sort((x, y) => x.ArrivalTime.CompareTo(y.ArrivalTime));

        foreach (Ship ship in ships)
        {
            bool berthAllocated = false;
            Console.WriteLine(ship.ToString());

            foreach (Quay quay in quays)
            {
                Console.WriteLine(quay.ToString());
                if (quay.AvailableCapacity > 0 && quay.AvailableCapacity >= ship.Size) //&& ship.ArrivalTime >= berth.Capacity, why?
                {
                    Console.WriteLine($"Ship {ship.Name} allocated to quay {quay.Name}");
                    quay.AvailableCapacity -= ship.Size;
                    berthAllocated = true;
                    break;
                }
            }

            if (!berthAllocated)
            {
                Console.WriteLine($"No quey available for Ship {ship.Name}");
            }
        }
    }
}
