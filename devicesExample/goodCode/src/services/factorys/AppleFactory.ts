import { IPhone } from "../../core/contracts/IPhone";
import { IWatch } from "../../core/contracts/IWatch";
import { ApplePhone } from "../../core/models/ios/ApplePhone";
import { AppleWatch } from "../../core/models/ios/AppleWatch";
import { IDeviceFactory } from "../contracts/IDeviceFactory";

export class AppleFactory implements IDeviceFactory{
  createWatch(): IWatch {
    return new AppleWatch()
  }
  createPhones(): IPhone {
    return new ApplePhone()
  }
}