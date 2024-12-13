using System;
using testeAbstractFactory.src.app.weapons;

namespace testeAbstractFactory.src.app.itens.weapons.basicWeapons;

public abstract class Sword : IWeapon
{
    public virtual void Attack(){
      Console.WriteLine("Balancando a espada");
    }
}
