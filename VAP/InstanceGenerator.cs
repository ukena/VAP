using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAP
{
    public class InstanceGenerator
    {
        public List<Ship> Generate()
        {
            {
                List<Ship> ships = new List<Ship>();
                for (int i = 1; i <= 10; i++)
                {
                    string shipName = "Ship" + i;
                    int arrivalTime = i * 2;
                    int departureTime = i * 5;
                    int size = i;

                    Ship ship = new Ship(shipName, arrivalTime, departureTime, size);
                    ships.Add(ship);
                }
                return ships;
            }
        }
    }
}
