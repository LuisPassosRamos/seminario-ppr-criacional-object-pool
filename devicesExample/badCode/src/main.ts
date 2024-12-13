import { DeviceFactory } from "./service/DeviceFactory";

const deviceFactory = new DeviceFactory();

const androidPhone = deviceFactory.createDevice("Android", "Phone");
console.log(androidPhone.getInfo());

const appleWatch = deviceFactory.createDevice("Apple", "Watch");
console.log(appleWatch.getAbout());
