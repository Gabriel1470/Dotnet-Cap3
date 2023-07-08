var randList = new Random();
var doubleList = new List<double>();

for  (int i = 0; i < 10; i++)
{
    doubleList.Add(randList.NextDouble() * 10);
}

Console.WriteLine($"Elementi numerici nella lista {doubleList.Count()}");
Console.WriteLine("Digita un numero per Skip");
int usInp1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digita un numero per Take");
int usInp2 = int.Parse(Console.ReadLine());

var skTkList = doubleList.Skip(usInp1).Take(usInp2);

var somma = skTkList.Sum();
var media = skTkList.Average();
var conta = skTkList.Count();

Console.WriteLine("somma di tutti gli elementi della lista: " + somma);
Console.WriteLine("media della lista: " + media);
Console.WriteLine("la lista ha " + conta + " elementi");