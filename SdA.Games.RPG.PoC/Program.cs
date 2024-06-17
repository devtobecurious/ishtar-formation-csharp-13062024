using SdA.Games.RPG.Core.Models;

Character mainCharacter = new MainCharacter("Sam", new Power[] { });
Character enemy = new Urukai("Fiouklmo");


void Run(Character a, Character b)
{
    a.Attack(b);
    b.Attack(a);
}

Run(mainCharacter, enemy);