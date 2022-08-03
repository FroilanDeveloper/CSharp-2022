  Human froilan = new Human("Froilan", 5, 100, 10, 200);

  Human aaron = new Human("Aaron");

  Console.WriteLine(froilan.Attack(aaron));

  Wizard sherline = new Wizard("Sherline", 10, 200);

  Console.WriteLine(sherline.Health);

  Console.WriteLine(sherline.Attack(aaron));

  Console.WriteLine(sherline.Heal(aaron));

  Ninja alex = new Ninja("Alex", 5, 100, 100);

  Console.WriteLine(alex.Steal(froilan));
  Console.WriteLine(alex.Attack(aaron));

  Samurai juan = new Samurai("Juan", 5, 100, 100);

  Console.WriteLine(juan.Attack(froilan));
  Console.WriteLine(juan.Attack(froilan));
  Console.WriteLine(juan.Attack(froilan));
  Console.WriteLine(juan.Attack(froilan));
  Console.WriteLine(juan.Attack(froilan));
  Console.WriteLine(juan.Attack(froilan));
  Console.WriteLine(juan.Attack(froilan));
  Console.WriteLine(juan.Attack(froilan));
  Console.WriteLine(juan.Attack(froilan));
  Console.WriteLine(juan.Attack(froilan));
