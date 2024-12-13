using testeAbstractFactory.src.app.itens.weapons.basicWeapons;
using testeAbstractFactory.src.app.itens.weapons.contracts;

namespace testeAbstractFactory.src.app.itens.weapons.magicWeapons;

public class MagicWand : Wand, IMagicWeapon
{
    public void CastSpell()
    {
      Console.WriteLine($"Lançando feitiço com a varinha");
    }

}