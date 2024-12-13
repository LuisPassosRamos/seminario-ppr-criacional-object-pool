import { IPhone } from "../../contracts/IPhone";

export class ApplePhone implements IPhone{
  getDetails(): string {
    return "Abrindo a apple store"
  }
}