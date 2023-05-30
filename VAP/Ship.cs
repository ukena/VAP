using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ship
{
    public string Name { get; init; }
    private int _arrivalTime;
    public int ArrivalTime
    {
        get { return _arrivalTime; }
        set
        {
            try
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{Name} cannot have a negative arrival time");
                }
                else
                {
                    _arrivalTime = value;
                }
            }
            catch (ArgumentException ex)
            {
                throw;
            }
        }
    }
    private int _departureTime;
    public int DepartureTime
    {
        get { return _departureTime; }
        init
        {
            try
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{Name} cannot have a negative departure time");
                }
                else
                {
                    _departureTime = value;
                }
            }
            catch (ArgumentException ex)
            {
                throw;
            }
        }
    }
    public int StayDuration { get; init; }
    private int _size;
    public int Size
    {
        get { return _size; }
        init
        {
            try
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{Name} cannot have a negative size");
                }
                else
                {
                    _size = value;
                }
            }
            catch (ArgumentException ex)
            {
                throw;
            }
        }
    }

    public Ship(string name, int arrivalTime, int departureTime, int size)
    {
        try
        {
            Name = name;
            ArrivalTime = arrivalTime;
            DepartureTime = departureTime;
            StayDuration = departureTime - arrivalTime;
            Size = size;
        }
        catch (ArgumentException ex)
        {
            throw;
        }
    }

    public override string ToString()
    {
        return $"Ship Details: Name={Name}, ArrivalTime={ArrivalTime}, DepartureTime={DepartureTime}, Size={Size}";
    }
}
