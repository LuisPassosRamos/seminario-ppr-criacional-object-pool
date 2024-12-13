using testeAbstractFactory.src.app.itens.factorys;
using testeAbstractFactory.src.app.itens.weapons.basicWeapons;

namespace testeAbstractFactory.src.app.npcs;

public class BasicBlackSmith : IWeaponFactory
{
  public Sword CreateSword()
  {
    return new BasicSword();
  }

  public Bow CreateBow()
  {
    return new BasicBow();
  }

  public Wand CreateWand()
  {
    return new BasicWand();
  }

}
