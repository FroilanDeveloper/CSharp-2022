//  Fundamentals Assignments
// ----------------------------------------------------------------

// 1. Create a Loop that prints all values from 1-255
for (int i = 1; i <= 255; i++)
{
  Console.WriteLine(i);
}

Console.WriteLine("***********************");

// 2. Create a new loop that prints all values from 1-100 that are divible by 3 or 5, but not both 
Console.WriteLine("Divisible by 3 & 5: ");
for (int i = 1; i <= 100; i++)
{
  if (i % 3 == 0 && i % 5 == 0)
  {
    Console.WriteLine(i); // Console.WriteLine is inside the Curly Brackets {}
  }
}

Console.WriteLine("*******************");



// 3. Modify the previous loop to print "Fizz" for multiples of 3,"Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5

for (int i = 1; i <= 100; i++)
{
  if (i % 3 == 0 && i % 5 == 0)
  {
    Console.WriteLine("FizzBuzz");
  }
  else if (i % 3 == 0)
  {
    Console.WriteLine("Fizz");
  }
  else if (i % 5 == 0)
  {
    Console.WriteLine("Buzz");
  }
  else
  {
    Console.WriteLine(i);
  }
}

Console.WriteLine("*******************");




// ****************************  Solutions ****************************

// Create a Loop that prints all values from 1-255
for (var value = 0; value <= 255; value++)
{
  Console.WriteLine(value);
}

// Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
for (var value = 1; value <= 100; value++)
{
  bool byThreeOrFive = (value % 3 == 0 || value % 5 == 0);
  bool notThreeAndFive = !(value % 3 == 0 && value % 5 == 0);

  if (byThreeOrFive && notThreeAndFive)
  {
    Console.WriteLine(value);
  }
}

// Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
for (var value = 1; value <= 100; value++)
{
  bool byThree = (value % 3 == 0);
  bool byFive = (value % 5 == 0);
  bool byThreeAndFive = (value % 3 == 0 && value % 5 == 0);

  if (byThreeAndFive)
  {
    Console.WriteLine($"Fizz Buzz (value:{value})");
  }
  else if (byThree)
  {
    Console.WriteLine($"Fizz (value:{value})");
  }
  else if (byFive)
  {
    Console.WriteLine($"Buzz (value:{value})");
  }
}



// // For Loops NOTES

// // loop from 1 to 5 including 5
// for (int i = 1; i <= 5; i++)
// {
//   Console.WriteLine(i);
// }
// // loop from 1 to 5 excluding 5
// for (int i = 1; i < 5; i++)
// {
//   Console.WriteLine(i);
// }

// Console.WriteLine("*******************************");

// // You can just as easily use variables to create a range as well!
// int start = 0;
// int end = 5;
// // loop from start to end including end
// for (int i = start; i <= end; i++)
// {
//   Console.WriteLine(i);
// }
// // loop from start to end excluding end
// for (int i = start; i < end; i++)
// {
//   Console.WriteLine(i);
// }

// Console.WriteLine("*****************************");

// // We can re-write this for loop...
// //The execution section does not always have to use ++
// for (int i = 1; i < 6; i = i + 1)
// {
//   Console.WriteLine(i);
// }

// Console.WriteLine("*****************************");

// // ... as a while loop
// // int i = 1;
// // while (i < 6)
// // {
// //   Console.WriteLine(i);
// //   i = i + 1;
// // }

// // Note that the while loop syntax requires us to create our own bounds. In later assignments, you may find situations where you don't know how many times you will need to repeat before entering the loop, and it will be important to know how to use a while loop.

// Random rand = new Random();
// for(int val = 0; val < 10; val++)
// {
//   //Prints the next random value between 2 and 8
//   Console.WriteLine(rand.Next(1,9));
// }

