// See https://aka.ms/new-console-template for more information
using Task1.Enums;
using Task1.Vehicles;
using Task1.Vehicles.Combat;
using Task1.Vehicles.Consumer;
using Task1.Vehicles.Public;
using Task1.Vehicles.Sport;
using static Task1.Enums.Enums;

Console.WriteLine("Select vehicle type: {0}", EnumsHelper.GetEnumAsString<Enums.VehicleType>());

if (!int.TryParse(Console.ReadLine(), out int vehicleTypeValue) || !EnumsHelper.IsDefined<Enums.VehicleType>(vehicleTypeValue))
{
    Console.WriteLine("Invalid vehicle type, try again");
    return;
}

string vehicleType = EnumsHelper.GetEnumName<Enums.VehicleType>(vehicleTypeValue);


Console.WriteLine("Select {0} type: {1}", vehicleType, EnumsHelper.GetEnumAsString(vehicleType));

if (!int.TryParse(Console.ReadLine(), out int vehicleSubTypeValue) || !EnumsHelper.IsDefined(vehicleType, vehicleSubTypeValue))
{
    Console.WriteLine("Invalid {0} type, try again", vehicleType);
    return;
}

string vehicleSubType = EnumsHelper.GetEnumName(vehicleType, vehicleSubTypeValue);

IVehicle vehicle = getVehicle(vehicleSubType);

IVehicle getVehicle(string vehicleSubType)
{
    IVehicle vehicle = default;

    switch(vehicleSubType.ToLower())
    {
        case "tank":
            vehicle = new Tank();
            break;
        case "beter":
            vehicle = new Beter();
            break;
        case "sedan":
            vehicle = new Sedan();
            break;
        case "jeep":
            vehicle = new Jeep();
            break;
        case "motorcylce":
            vehicle = new Motorcycle();
            break;
        case "bicycle":
            vehicle = new Bicycle();
            break;
        case "bus":
            vehicle = new Bus();
            break;
        case "tram":
            vehicle = new Tram();
            break;
        case "formula1":
            vehicle = new Formula1();
            break;
        case "rally":
            vehicle = new Rally();
            break;
        case "offroad":
            vehicle = new OffRoad();
            break;
    }

    return vehicle;
}

ac(vehicle);
void ac(IVehicle vehicle)
{
    if (vehicle == null)
    {
        return;
    }
    vehicle.move();
    vehicle.breaking();

    Console.WriteLine(vehicle.NumberOfSeats);
    Console.WriteLine(vehicle.MaxSpeed);
}

/*Beter beter = new Beter(16, 140, 17, true);
beter.move();
beter.breaking();
beter.shoot();
beter.swiiming();
Console.WriteLine(beter.NumberOfWeapons);
Console.WriteLine(beter.NumberOfSeats);
Console.WriteLine(beter.MaxSpeed);
Console.WriteLine(beter.CanSwimm);

Tank tank = new Tank(8, 80, 7, true);
tank.move();
tank.breaking();
tank.shoot();
tank.activateLaserMode();
Console.WriteLine(tank.NumberOfWeapons);
Console.WriteLine(tank.NumberOfSeats);
Console.WriteLine(tank.MaxSpeed);
Console.WriteLine(tank.HasLaserSystem);*/

/*Sedan honda = new Sedan();
honda.refueling();
honda.move();
honda.breaking();*/

/*Bus bus = new Bus();
bus.LineNumber = 33;
Console.WriteLine(bus.LineNumber);
bus.move();
bus.breaking();
bus.openDoor();

Tram tram = new Tram();
tram.LineNumber = 32;
Console.WriteLine(tram.LineNumber);
tram.move();
tram.breaking();
tram.openDoor();*/
