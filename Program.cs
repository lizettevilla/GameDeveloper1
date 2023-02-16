Enemy Bandit = new Enemy("Bandit");
Attack FireBall = new Attack("FireBall", 20);
Attack Punch = new Attack("Punch", 10);
Attack Kick = new Attack("Kick", 5);
Bandit.AddAttack(FireBall).AddAttack(Punch).AddAttack(Kick);
Bandit.RandomAttack();
Bandit.PrintInfo();