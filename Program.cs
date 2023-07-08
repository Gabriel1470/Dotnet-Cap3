var randList = new Random();
var intList = new List<int>();
for (int i = 0; i < 1000; i++)
{
    intList.Add(randList.Next(0, 1001));
}
var results = intList.Where(i => i % 2 == 1);
   

results.ToList().ForEach(result => Console.Write(result + " - "));