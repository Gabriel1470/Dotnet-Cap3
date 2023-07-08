var oneList = new List<string>() {"lista1-1"};
var twoList = new List<string>() {"lista2-2", "lista3-3"};

Console.WriteLine(oneList.FirstOrDefault());
Console.WriteLine(twoList.FirstOrDefault());

Console.WriteLine(oneList.SingleOrDefault());
Console.WriteLine(twoList.SingleOrDefault());