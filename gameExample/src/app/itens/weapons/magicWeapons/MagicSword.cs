using System;
using testeAbstractFactory.src.app.itens.weapons.basicWeapons;
using testeAbstractFactory.src.app.itens.weapons.contracts;

namespace testeAbstractFactory.src.app.itens.weapons.magicWeapons;

public class MagicSword : Sword, IMagicWeapon
{
    public override void Attack()
    {
      Console.WriteLine($"Atacando com a espada mágica");
    }
    
    public void CastSpell()
    {
      Console.WriteLine($"Lançando feitiço com a espada");
    }
}
