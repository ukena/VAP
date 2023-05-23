using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ship
{
    public string Name { get; set; }
    public int ArrivalTime { get; set; }
    public int DepartureTime { get; set; }

    public Ship(string name, int arrivalTime, int departureTime)
    {
        Name = name;
        ArrivalTime = arrivalTime;
        DepartureTime = departureTime;
    }
}