var randList = new Random();
var intList = new List<int>();
for (int i = 0; i < 1000; i++)
{
    intList.Add(randList.Next(0, 1001));
}
var results =
    from integer in intList
    where integer % 2 == 1
    select integer;
;
results.ToList().ForEach(result => Console.Write(result + " - "));