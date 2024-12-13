
using testeAbstractFactory.src.app.itens.factorys;
using testeAbstractFactory.src.app.itens.weapons.basicWeapons;

namespace testeAbstractFactory.src.app.worldObjects.chests;

public class WeaponChests : IWeaponFactory
{
    public Bow CreateBow()
    {
        return new BasicBow();
    }

    public Sword CreateSword()
    {
        return new BasicSword();
    }

    public Wand CreateWand()
    {
        return new BasicWand();
    }
}
