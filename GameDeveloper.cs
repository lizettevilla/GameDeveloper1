class Attack {
    public string Name;
    public int DamageAmount;
    
   public Attack(string n, int d)
    {
        Name = n;
        DamageAmount = d;
    }
}

class Enemy {
    public string Name;
    public int Health;
    public List<Attack> AttackList;
    List<Attack> Attacks = new List<Attack>(){new Attack("Punch", 10),new Attack("Kick", 5),new Attack("Block",0)};
    public Enemy(string n)
    {
        Name = n;
        Health = 100;
        AttackList = Attacks;
    }

public void PrintInfo()
{
    Console.WriteLine($"Enemy Name: {this.Name} - Enemy Health: {this.Health}");
    foreach(Attack item in AttackList)
    {
        Console.WriteLine($"Attack: {item.Name} | Damage: {item.DamageAmount}");
    }
}

public void RandomAttack()
{
    Random rand = new Random();
    Console.WriteLine($"{AttackList[rand.Next(0,AttackList.Count)].Name}");
}

public Enemy AddAttack(Attack att)
{
    AttackList.Add(att);
    return this;
}
}