class Samurai: Human{
  public Samurai(
    string name,
    int strength,
    int intelligence,
    int dexterity
  ): base(name){
    Name = name;
    Strength = strength;
    Intelligence = intelligence;
    Dexterity = dexterity;
    Health = 200;
  }

  public override int Attack(Human target){
    base.Attack(target);
    if(target.Health <= 50){
      target.Health = 0;
    }
    return target.Health;
  }

  public int Meditate(){
    Health = 200;
    return Health;
  }

}