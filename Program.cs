using Dotnet_Cap3;

var random  = new Random();
var numbers = new List<int>();

for  (int i = 0; i < 100; i++)
{
    numbers.Add(random.Next(0,10000));
}

var results = numbers.Select(number => new NumberMetaData(number)).ToList();

results.ForEach(result => {
    Console.WriteLine($" \n Number: {result.Number} \n isEven: {result.IsEven()} \n Number of Character {result.NumberOfCharacters()}");
  
});