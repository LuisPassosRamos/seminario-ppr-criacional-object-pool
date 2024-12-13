using testeAbstractFactory.src.app.itens.weapons.basicWeapons;
using testeAbstractFactory.src.app.itens.weapons.contracts;

namespace testeAbstractFactory.src.app.itens.weapons.mutationWeapons;

public class MutationWand : Wand, IAnimalMutationWeapon
{
    public void ChangeToAnimal()
    {
      Console.WriteLine($"Transformando a varinha em um animal");
    }
}

