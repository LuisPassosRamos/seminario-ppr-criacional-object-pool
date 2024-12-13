using testeAbstractFactory.src.app.itens.weapons.basicWeapons;
using testeAbstractFactory.src.app.itens.weapons.contracts;

namespace testeAbstractFactory.src.app.itens.weapons.mutationWeapons;

public class MutationSword : Sword, IAnimalMutationWeapon
{
    public void ChangeToAnimal()
    {
      Console.WriteLine("Transformando a espada em um aniaml");
    } 
}
