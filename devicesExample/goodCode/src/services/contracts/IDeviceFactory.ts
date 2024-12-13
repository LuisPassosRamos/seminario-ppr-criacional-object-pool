import { IPhone } from "../../core/contracts/IPhone";
import { IWatch } from "../../core/contracts/IWatch";

export interface IDeviceFactory{
  createWatch() : IWatch
  createPhones(): IPhone
} 