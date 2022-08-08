int[] numbers = new int[10];
Random rand = new Random();
int max = 0;
int min = 15;
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
  numbers[i] = rand.Next(5, 26);
  sum += numbers[i];

  if (max < numbers[i])
  {
    max = numbers[i];
  }

  if (min > numbers[i])
  {
    min = numbers[i];
  }
}

Console.WriteLine($"{max}  {min}  {sum}");
foreach (int num in numbers)
{
  Console.WriteLine(num);
}


static string TossCoin()
{
  Random rand = new Random();
  Console.WriteLine("Tossing a Coin!");
  int result = rand.Next(1, 3);
  if (result == 1)
  {
    return "Head";
  }
  else
  {
    return "Tails";
  }
}
Console.WriteLine(TossCoin());

static List<string> Names()
{
  List<string> nameList = new List<string>() { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
  List<string> newList = new List<string>() { };
  foreach (string name in nameList)
  {
    if (name.Length > 5)
    {
      newList.Add(name);
    }
  }
  return newList;
}
List<string> resultList = Names();

foreach (string name in resultList)
{
  Console.WriteLine(name);
}

