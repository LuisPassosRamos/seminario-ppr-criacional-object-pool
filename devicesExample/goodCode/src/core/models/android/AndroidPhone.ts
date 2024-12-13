import { IPhone } from "../../contracts/IPhone"

export class AndroidPhone implements IPhone{
  getDetails(): string {
    return "Abrindo a play Store"
  }
}