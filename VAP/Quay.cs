using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Quay
{
    public string Name { get; init; }
    private int _capacity;
    public int Capacity
    {
        get { return _capacity; }
        init
        {
            try
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{Name} cannot have a negative capacity");
                }
                else
                {
                    _capacity = value;
                }
            }
            catch (ArgumentException ex)
            {
                throw;
            }
        }
    }
    public int AvailableCapacity { get; set; }

    public Quay(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
        AvailableCapacity = capacity;
    }

    public override string ToString()
    {
        return $"Quay Details: Name={Name}, Capacity={Capacity}, AvailableCapacity={AvailableCapacity}";
    }
}
