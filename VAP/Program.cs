using VAP;

int[] numberOfShipsValues = { 5, 15, 25 };
int minLength = 5;
int maxLength = 10;
int minLayTime = 3;
int maxLayTime = 7;
int numberOfInstancesPerValue = 10;
int[] berthLengthValues = { 5, 10, 15 };
int seed = 42;

// BerthAllocationInstance.GenerateInstances(numberOfShipsValues, minLength, maxLength, minLayTime, maxLayTime, berthLengthValues, numberOfInstancesPerValue, seed);

string[] filePaths = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "../../../Data"), "*.txt");

foreach (string filePath in filePaths)
{
    BerthAllocationInstance instance = BerthAllocationInstance.ReadInstances(filePath);
    
}

