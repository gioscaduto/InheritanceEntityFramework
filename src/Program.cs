using InheritanceEntityFramework.Configurations;
using InheritanceEntityFramework.FakeData;
using InheritanceEntityFramework.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddDataInfrastructure();
services.ResolveDependencies();

var vehicleService = services.BuildServiceProvider()
    .GetRequiredService<IVehicleService>();

var car = FakeData.GenerateValidCar();
var motorCycle = FakeData.GenerateValidMotorCycle();

await vehicleService.Add(car);
await vehicleService.Add(motorCycle);

car.Update(numberOfDoors: 3, hasAirConditioning: false);
motorCycle.Update(hasSidecar: true);

await vehicleService.UpdateOnlySpecificProperties(car);
await vehicleService.UpdateOnlySpecificProperties(motorCycle);