using System;
using testeAbstractFactory.src.app.itens.factorys;
using testeAbstractFactory.src.app.itens.weapons.basicWeapons;
using testeAbstractFactory.src.app.itens.weapons.magicWeapons;

namespace testeAbstractFactory.src.app.npcs.blackSmith;

public class MagicBlackSmith : IWeaponFactory
{
  public Sword CreateSword()
  {
    return new MagicSword();
  }

  public Bow CreateBow()
  {
    return new MagicBow();
  }

  public Wand CreateWand()
  {
    return new MagicWand();
  }
}
