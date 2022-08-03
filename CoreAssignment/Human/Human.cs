class Human
{
  // Properties for Human
  public string Name;
  public int Strength;
  public int Intelligence;
  public int Dexterity;
  public int Health;
  // Add a constructor that takes a value to set Name, and set the remaining fields to default values

  public Human(string name)
  {
    Name = name; // left Name Property of human : Right name what we set the value too
    Strength = 3;
    Intelligence = 3;
    Dexterity = 3;
    Health = 100;
  }

  public Human(string name, int strength, int intelligence, int dexterity, int health)
  {
    Name = name;
    Strength = strength;
    Intelligence = intelligence;
    Dexterity = dexterity;
    Health = health;
  }

  // Add a constructor to assign custom values to all fields

  // Build Attack method
  public virtual int Attack(Human target)
  {
    target.Health -= this.Strength * 5;
    return target.Health;
  }
}




