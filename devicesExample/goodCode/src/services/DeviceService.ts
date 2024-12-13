import { IDeviceFactory } from "./contracts/IDeviceFactory";
import { AndroidFactory } from "./factorys/AndroidFactory";
import { AppleFactory } from "./factorys/AppleFactory";

export class DeviceService{
  static getDeviceFactory(type: "Android" | "Apple") : IDeviceFactory {
    if(type == "Android"){
      return new AndroidFactory();
    }else if(type == "Apple"){
      return new AppleFactory();
    }
    throw new Error("Invalid device type");
  }
}