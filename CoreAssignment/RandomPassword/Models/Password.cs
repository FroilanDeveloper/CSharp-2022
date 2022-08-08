#pragma warning disable CS8618

namespace RandomPassword.Models;

public class Password
{
  public string Passwords { get; set; }

  public string RandomGenerateString()
  {
    string AlphabetNums = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    Random random = new Random();
    character[] characters = new character[14];
    for (int i = 0; i < characters.Length; i++)
    {
      characters[i] = AlphabetNums[random.Next(AlphabetNums.Length)];
    }
    Password = new string(characters);
    return Password;
  }
}