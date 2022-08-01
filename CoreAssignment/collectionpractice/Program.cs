

List<string> flavors = new List<string>() {
  "cherry garcia",
  "mint chocolate chip",
  "chocolate",
  "chocolate chip",
  "lobster"
};

flavors.Add("caramel");
flavors.RemoveAt(4);
flavors.Insert(2,"caramel");

Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[1]);

foreach (string a in flavors)
{
  Console.WriteLine(a);
}

// a is a variable it can be named anything

List<int> orderedNums = new List<int>() {
  1,2,3,4,5,6,7,8,9,10,11,12,13 
};

List<int> shuffleNums = new List<int>(); 

Random rand= new Random();

// Console.WriteLine(rand.Next(0,15));

while (orderedNums.Count > 0) 
{
  int randIdx = rand.Next(0, orderedNums.Count);
  shuffleNums.Add(orderedNums[randIdx]);
  orderedNums.RemoveAt(randIdx);
}

foreach (int num in shuffleNums)
{
  Console.WriteLine(num);
}