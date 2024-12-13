using System;

namespace testeAbstractFactory.src.app.itens.weapons.basicWeapons;

public class BasicSword : Sword
{
  public override void Attack()
  {
    Console.WriteLine("Atacando com a espada basica");
  }
}
