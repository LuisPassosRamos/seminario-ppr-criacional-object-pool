import { AndroidPhone } from "../models/AndroidPhone";
import { AndroidWatch } from "../models/AndroidWatch";
import { ApplePhone } from "../models/ApplePhone";
import { AppleWatch } from "../models/AppleWatch";

export class DeviceFactory {
  createDevice(type: string, device: string) : any {
    if (type === "Android" && device === "Watch") {
      return new AndroidWatch();
    } else if (type === "Android" && device === "Phone") {
      return new AndroidPhone();
    } else if (type === "Apple" && device === "Watch") {
      return new AppleWatch();
    } else if (type === "Apple" && device === "Phone") {
      return new ApplePhone();
    } else {
      throw new Error("Invalid type or device");
    }
  }
}