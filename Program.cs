var randList = new Random();
var doubleList = new List<double>();

for  (int i = 0; i < 10; i++)
{
    doubleList.Add(randList.NextDouble()*10);
}

var somma = doubleList.Sum();
var media = doubleList.Average();
var conta = doubleList.Count();

Console.WriteLine("somma di tutti gli elementi della lista: " + somma);
Console.WriteLine("media della lista: " + media);
Console.WriteLine("la lista ha " + conta + " elementi");