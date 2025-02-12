using System;
using testeAbstractFactory.src.app.itens.weapons.basicWeapons;

namespace testeAbstractFactory.src.app.itens.factorys;

public interface IWeaponFactory
{
  Sword CreateSword();
  Bow CreateBow();
  Wand CreateWand();
}
