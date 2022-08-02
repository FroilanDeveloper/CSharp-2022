// Collections Practice Assignment


// 1. Three basic Arrays 
// 1.1 Create an array to hold interger values 0 through 9
// 1.2 Create an array the names "Tim","Martin","Nikki",& "Sara"
// 1.3 Create an array of length 10 that alternates between true and false values, starting with true

int[] array1 = {0,1,2,3,4,5,6,7,8,9};

foreach(int listnum in array1){
  Console.WriteLine(listnum);
}

string[] array2 = {"Tim", "Martin", "Nick", "Sara"};

foreach(string names in array2){
  Console.WriteLine(names);
}

bool[] array3 = new bool[10];
array3[0] = true;
array3[1] = false;
array3[2] = true;
array3[3] = false;
array3[4] = true;
array3[5] = false;
array3[6] = true;
array3[7] = false;
array3[8] = true;
array3[9] = false;

foreach (bool nums in array3) {
  Console.WriteLine(nums);
}

for (int i = 0; i <= 10; i++)
{
  bool values = i % 2 == 0;
  bool values1 = i % 1 == 0;

  if ( values1 && values) 
  {
    Console.WriteLine( i + " True");
  } 
  else if (values1)
  {
    Console.WriteLine(i + " False");
  } 
  else 
  {
    Console.WriteLine(i);
  }
} 








List<string> flavors = new List<string>() {
  "cherry garcia",
  "mint chocolate chip",
  "chocolate",
  "chocolate chip",
  "lobster",
  "cookies&cream"
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

// List<int> orderedNums = new List<int>() {
//   1,2,3,4,5,6,7,8,9,10,11,12,13
// };

// List<int> shuffleNums = new List<int>();



// Console.WriteLine(rand.Next(0,15));

// while (orderedNums.Count > 0)
// {
//   int randIdx = rand.Next(0, orderedNums.Count);
//   shuffleNums.Add(orderedNums[randIdx]);
//   orderedNums.RemoveAt(randIdx);
// }

// foreach (int num in shuffleNums)
// {
//   Console.WriteLine(num);
// }



Dictionary<string, string> persons = new Dictionary<string, string>();
Random rand = new Random();

for (int i = 0; i < array2.Length; i++)
{  // were getting a random number from 0 to 7 
  int randIdx = rand.Next(flavors.Count); // automatically sets to 0.= min, array2.Length = max
  persons.Add(array2[i], flavors[randIdx]);
}

foreach(KeyValuePair<string, string> entry in persons)
{
  Console.WriteLine($"Name: {entry.Key} Flavor: {entry.Value}");
}




