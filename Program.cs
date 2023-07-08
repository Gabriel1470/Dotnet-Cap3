using Dotnet_Cap3;

var randList = new Random();
var intList = new List<int>();
for (int i = 0; i < 1000; i++)
{
    intList.Add(randList.Next(0, 1001));
}
var results = intList.OrderBy(i => i, new Calcola()).ToList();
results.ForEach(i => Console.Write(i + " - "));
