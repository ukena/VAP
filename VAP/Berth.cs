﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Berth
{
    public string Name { get; set; }
    public int Capacity { get; set; }

    public Berth(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }
}
