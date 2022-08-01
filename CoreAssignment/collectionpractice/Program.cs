// Collections Practice Assignment

// 1. Three basic Arrays 
// 1.1 Create an array to hold interger values 0 through 9
// 1.2 Create an array the names "Tim","Martin","Nikki",& "Sara"
// 1.3 Create an array of length 10 that alternates between true and false values, starting with true

int[] array1 = {0,1,2,3,4,5,6,7,8,9};
string[] array2 = {"Tim", "Martin", "Nick", "Sara"};
bool[] array3 = new bool[10];
array3[0] = true;
array3[1] = false;
array3[2] = true;
array3[3] = false;
array3[4] = true;
array3[5] = false;
array3[6] = false;
array3[7] = true;
array3[8] = false;
array3[9] = true;










List<string> flavors = new List<string>() {
  "cherry garcia",
  "mint chocolate chip",
  "chocolate",
  "chocolate chip",
  "lobster"
};

flavors.Add("caramel");
flavors.RemoveAt(4);
flavors.Insert(2, "caramel");

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

Random rand = new Random();

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


Dictionary<string, string> someDictionary = new Dictionary<string, string>() {
  {"name", "joseph"},
  {"favorite_color", "purple"},
  {"23", "jonas"}
};

Console.WriteLine(someDictionary["name"]);
Console.WriteLine(someDictionary["23"]);
Console.WriteLine(someDictionary["favorite_color"]);