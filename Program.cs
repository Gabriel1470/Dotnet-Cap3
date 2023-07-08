var randList = new Random();
var intList = new List<int>();
for (int i = 0; i < 1000; i++)
{
    intList.Add(randList.Next(0, 1001));
}
var results = intList.Where(integ => integ % 2 == 1);
results.ToList().ForEach(result => Console.Write(result + " - "));

var ordered =
    from i in intList
    orderby i
    select i;
    
Console.WriteLine("-----------------------------------------------------\n");
   Console.WriteLine("Ordered List \n");
ordered.ToList().ForEach(x => Console.Write(x + " - "));
Console.WriteLine();
Console.WriteLine("------------------------------------------------------\n");

var reversed =
    from i in intList
    orderby i descending
    select i;

    Console.WriteLine("Reversed List \n");
    
reversed.ToList().ForEach(x => Console.Write(x + " - "));
Console.WriteLine();