class Ninja : Human
{
  public Ninja(
    string name,
    int strength,
    int intelligence,
    int health
  ): base(name){
    Name = name;
    Strength = strength;
    Intelligence = intelligence;
    Health = health;
    Dexterity = 175;
  }

  public override int Attack(Human target)
  {
    Random rand = new Random();
    int roll = rand.Next(1, 6);

    if (roll == 2)
    {
      target.Health -= ((Dexterity * 5) + 10);
      Console.WriteLine($"Target was hit by a critical! Current Health: {target.Health}");
    }
    else
    {
      target.Health -= (Dexterity * 5);
      Console.WriteLine($"Target was hit! Current Health: {target.Health}");
    }
    return target.Health;
  }

  public virtual int Steal(Human target)
  {
    target.Health -= 5;
    this.Health += 5;
    Console.WriteLine($"Targets Health is now: {target.Health}");
    Console.WriteLine($"Your Health is now: {this.Health}");
    return target.Health;
  }
}