import { IWatch } from "../../contracts/IWatch";

export class AppleWatch implements IWatch{
  getDetails(): string {
    return "Vendo a hora com meu relogio da Apple"
  }
} 