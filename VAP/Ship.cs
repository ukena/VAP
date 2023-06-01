using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ship
{
    public int Index { get; set; }
    public int Length { get; set; }
    public int LayTime { get; set; }

    public Ship(int index, int length, int layTime)
    {
        Index = index;
        Length = length;
        LayTime = layTime;
    }
}