using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAP
{
    public class SimpleBerth : BerthAllocationProblem
    {
        public int ShipCount { get; private set; }
        private int columns; // time
        private List<int> rows; // position

        public SimpleBerth()
            : base() { }

        public override void AddShip(string name, int arrivalTime, int departureTime, int size)
        {
            base.AddShip(name, arrivalTime, departureTime, size);
            ShipCount++;
        }

        public void PrintShips()
        {
            foreach (Ship ship in ships)
            {
                Console.WriteLine(ship.ToString());
                Console.WriteLine("Ship count: " + ShipCount);
            }
        }

        public void PrintQuays()
        {
            foreach (Quay quay in quays)
            {
                Console.WriteLine(quay.ToString());
            }
        }

        private void CreateMatrix()
        {
            rows = new List<int>();
            columns = quays[0].Capacity;
        }

        private void fillMatrix()
        {
            bool x_ij = false; // x_ij = true if ship i leaves quay before ship j arrives
            bool y_ij = false; // y_ij = true if ship i is parked on the left side of ship j
            List<Ship> allocatedShips = new List<Ship>(); // A (i)
            Ship shortestStayShip = ships.OrderBy(s => s.StayDuration).First(); //v (ii)
            shortestStayShip.ArrivalTime = 0; // s_v := eternity,  (iii)
            int layingPosStart = quays[0].Capacity - shortestStayShip.Size; // b_v := L - l_v (iii)
            int soonestArrivalTime; // s* := b_v, s_v := s* (iv)
            rows.Add(new int[columns] {1,2,3,4})
        }
    }
}
