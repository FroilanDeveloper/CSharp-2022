class Wizard: Human{
  public Wizard(
    string name,
    int strength,
    int dexterity
  ): base(name){
    Name = name; 
    Strength = strength;
    Dexterity = dexterity;
    Intelligence = 25;
    Health = 50;
  }

  public override int Attack(Human target){
    target.Health -= Intelligence * 5;
    Heal();
    return target.Health;
  }

  public int Heal(Human target){
    target.Health += Intelligence * 10;
    return target.Health;
  }

  public int Heal(){
    Health += Intelligence * 10;
    return Health;
  }
}