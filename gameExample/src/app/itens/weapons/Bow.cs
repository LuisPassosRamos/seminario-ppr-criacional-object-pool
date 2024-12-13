using System;
using testeAbstractFactory.src.app.weapons;

namespace testeAbstractFactory.src.app.itens.weapons.basicWeapons;

public abstract class Bow : IWeapon
{
  public virtual void Attack(){
    Console.WriteLine("Lancando flecha");
  }
}
