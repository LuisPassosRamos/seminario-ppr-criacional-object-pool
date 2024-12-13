import { IWatch } from "../../contracts/IWatch";

export class AndroidWatch implements IWatch{
  getDetails() : string{
    return "Vendo a hora no meu relogio com Android"
  }
}