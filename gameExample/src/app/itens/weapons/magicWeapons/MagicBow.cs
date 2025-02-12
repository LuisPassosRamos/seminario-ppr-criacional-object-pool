using System;
using testeAbstractFactory.src.app.itens.weapons.basicWeapons;
using testeAbstractFactory.src.app.itens.weapons.contracts;

namespace testeAbstractFactory.src.app.itens.weapons.magicWeapons;

public class MagicBow : Bow, IMagicWeapon
{
    public override void Attack()
    {
      Console.WriteLine($"Atacando com o arco mágico");
    }
    
    public void CastSpell()
    {
      Console.WriteLine($"Lançando feitiço com o arco");
    }

}
