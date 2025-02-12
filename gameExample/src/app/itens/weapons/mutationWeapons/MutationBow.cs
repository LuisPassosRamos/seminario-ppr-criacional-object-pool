using System;
using testeAbstractFactory.src.app.itens.weapons.basicWeapons;
using testeAbstractFactory.src.app.itens.weapons.contracts;

namespace testeAbstractFactory.src.app.itens.weapons.mutationWeapons;

public class MutationBow : Bow, IAnimalMutationWeapon
{
    public void ChangeToAnimal()
    {
      Console.WriteLine($"Transformando o arco em um animal");
    }
}
