var randList = new Random();
var intList = new List<int>();



for (int i = 0; i < 10; i++)
{
    intList.Add(randList.Next(0,10));
}

var pari = intList.All(x => x % 2 == 0);
var dispari = intList.Any(x => x % 2 == 1);

Console.WriteLine($"Sono tutti  pari? {pari}");
Console.WriteLine($"Ci sono numeri dispari? {dispari}");