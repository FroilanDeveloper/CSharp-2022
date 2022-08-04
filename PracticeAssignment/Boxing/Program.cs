
// Create an empty list of type object
// type object
List<object> lists = new List<object>(); 

// Add the value 7, 28, -1, true. "chair"
lists.Add(7);
lists.Add(28);
lists.Add(-1);
lists.Add(true);
lists.Add("chair");

int sum = 0;

// Loop through the list and print all values
foreach (var list in lists){
  Console.WriteLine(list);
  if (list is int){
    sum += (int)list;
  }
}

Console.WriteLine(sum);