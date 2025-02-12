import { IPhone } from "../../core/contracts/IPhone";
import { IWatch } from "../../core/contracts/IWatch";
import { AndroidPhone } from "../../core/models/android/AndroidPhone";
import { AndroidWatch } from "../../core/models/android/AndroidWatch";
import { IDeviceFactory } from "../contracts/IDeviceFactory";

export class AndroidFactory implements IDeviceFactory{
  createWatch(): IWatch {
    return new AndroidWatch();
  }
  createPhones(): IPhone {
    return new AndroidPhone();
  }

}