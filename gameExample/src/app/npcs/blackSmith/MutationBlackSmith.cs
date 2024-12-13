using System;
using testeAbstractFactory.src.app.itens.factorys;
using testeAbstractFactory.src.app.itens.weapons.basicWeapons;
using testeAbstractFactory.src.app.itens.weapons.mutationWeapons;

namespace testeAbstractFactory.src.app.npcs.blackSmith;

public class MutationBlackSmith : IWeaponFactory
{
  public Sword CreateSword()
  {
    return new MutationSword();
  }

  public Bow CreateBow()
  {
    return new MutationBow();
  }

  public Wand CreateWand()
  {
    return new MutationWand();
  }
}
