import { DeviceService } from "./services/DeviceService";

const androidWatch = DeviceService.getDeviceFactory("Android").createWatch();
console.log(androidWatch.getDetails());

const applePhone = DeviceService.getDeviceFactory("Apple").createPhones();
console.log(applePhone.getDetails());