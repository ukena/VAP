using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAP;

public class BerthAllocationInstance
{
    public Ship[] Ships { get; set; }
    public Berth Berth { get; set; }
    
    public static BerthAllocationInstance ReadInstances(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        
        int numberOfShips = int.Parse(lines[0]);

        Ship[] ships = new Ship[numberOfShips];
        for (int i = 0; i < numberOfShips; i++)
        {
            string[] shipData = lines[i + 1].Split(" ");
            int length = int.Parse(shipData[0]);
            int layTime = int.Parse(shipData[1]);

            ships[i] = new Ship(i + 1, length, layTime);
        }

        int berthLength = int.Parse(lines[numberOfShips + 1]);
        Berth berth = new Berth(berthLength);

        var instance = new BerthAllocationInstance
        {
            Ships = ships,
            Berth = berth
        };

        return instance;

    }

    public static void GenerateInstances(int[] numberOfShipsValues, int minLength, int maxLength, int minLayTime, int maxLayTime, int[] berthLengthValues, int numberOfInstancesPerValue, int seed)
    {
        Random random = new Random(seed);

        string dataDirectory = Path.Combine(Environment.CurrentDirectory, "../../../Data");

        foreach (int numberOfShips in numberOfShipsValues)
        {
            foreach (int berthLength in berthLengthValues)
            {
                for (int instanceIndex = 1; instanceIndex <= numberOfInstancesPerValue; instanceIndex++)
                {
                    Ship[] ships = new Ship[numberOfShips];
                    for (int i = 0; i < numberOfShips; i++)
                    {
                        int length = random.Next(minLength, maxLength + 1);
                        int layTime = random.Next(minLayTime, maxLayTime + 1);

                        ships[i] = new Ship(i + 1, length, layTime);
                    }

                    Berth berth = new Berth(berthLength);

                    var instance = new BerthAllocationInstance
                    {
                        Ships = ships,
                        Berth = berth
                    };

                    string fileName = $"instance_{numberOfShips}_{berthLength}_{instanceIndex}.txt";
                    string filePath = Path.Combine(dataDirectory, fileName);
                    instance.SaveToFile(filePath);
                }
            }
        }
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(Ships.Length);

            foreach (Ship ship in Ships)
            {
                writer.WriteLine($"{ship.Length} {ship.LayTime}");
            }

            writer.WriteLine(Berth.Length);
        }
    }
}

