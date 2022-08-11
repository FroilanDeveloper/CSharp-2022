List<Eruption> eruptions = new List<Eruption>()
{
  new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
  new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
  new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
  new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
  new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
  new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
  new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
  new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
  new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
  new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
  new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
  new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
  new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
  Console.WriteLine("\n" + msg);
  foreach (var item in items)
  {
    Console.WriteLine(item.ToString());
  }
}
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!


// 1. Use LINQ to find the first eruptions that is in Chile and print the result.
Console.WriteLine("1");
IEnumerable<Eruption> firstChileEruptions = eruptions.Where(c => c.Location == "Chile");
// PrintEach(firstChileEruptions, "Chile");

Console.WriteLine("*******************************");

// 2. Find the first eruptions from the "Hawaiian Is" location and print it. If none is found, print "No Hawaiian Is Eruption found."
Console.WriteLine("2");
IEnumerable<Eruption>  firstHawaiianEruptions = eruptions.Where(c => c.Location == "Hawaiian Is");
if (firstHawaiianEruptions == null)
{
  Console.WriteLine("No Hawaiian Is Eruption found.");
}
PrintEach(firstHawaiianEruptions, "Hawaiian Is");

Console.WriteLine("*******************************");

// 3. Find the first eruptions that is after the year 1900 AND "New Zealand", then print it.
IEnumerable<Eruption> firstNewZealandEruptions = eruptions.Where(c => c.Location == "New Zealand");
PrintEach(firstNewZealandEruptions, "New Zealand");

Console.WriteLine("*******************************");

// 4. Find all eruptions where the volcano's elevation is over 2000m and print them.
IEnumerable<Eruption> allEruptionsOver2000m = eruptions.Where(c => c.ElevationInMeters >= 2000);
PrintEach(allEruptionsOver2000m, "2000m");

Console.WriteLine("*******************************");

// 5. Find all eruptions where the volcano's name starts with "Z" and print them. Also print the number of eruptions found.
IEnumerable<Eruption> allZNameEruptions = eruptions.Where(c => c.Volcano.StartsWith("Z"));
int count = allZNameEruptions.Count();
PrintEach(allZNameEruptions, $"{count} was found");

Console.WriteLine("*******************************");

// 6. Find the highest elevation, and print only that integer.
int highestElevation = eruptions.Max(c => c.ElevationInMeters);
Console.WriteLine(highestElevation);

Console.WriteLine("*******************************");

// 7. Use the highest elevation variable to find a print the name of the Volcano with that elevation.
Eruption highestElevationName = eruptions.Where(c => c.ElevationInMeters == highestElevation).First();
Console.WriteLine(highestElevationName.Volcano);

Console.WriteLine("*******************************");

// 8. Print all Volcano names alphabetically.
IEnumerable<Eruption> alphabetically = eruptions.OrderBy(c => c.Volcano).ToList();
PrintEach(alphabetically);


Console.WriteLine("*******************************");

// 9. Print all the eruptions that happened before the year 1000 CE alphabetically according to Volcano name.
IEnumerable<Eruption> before1000Alphabetically = eruptions.Where(c => c.Year <= 1000).OrderBy(c => c.Volcano).ToList();
PrintEach(before1000Alphabetically);

