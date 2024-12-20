using InheritanceEntityFramework.Configurations;
using InheritanceEntityFramework.Entities;
using InheritanceEntityFramework.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddDataInfrastructure();
services.ResolveDependencies();

var serviceProvider = services.BuildServiceProvider();
var vehicleService = serviceProvider.GetRequiredService<IVehicleService>();

var car = new Car(brand: "Bugatti", model: "Chiron Super Sport 300+", 
    maximumSpeed: 304, numberOfDoors: 2, hasAirConditioning: true);

var motorCycle = new MotorCycle(brand: "Kawasaki", model: "Ninja H2R ", 
    maximumSpeed: 249, hasSidecar: false);

await vehicleService.Add(car);
await vehicleService.Add(motorCycle);

car.Update(numberOfDoors: 3, hasAirConditioning: false);
motorCycle.Update(hasSidecar: true);

await vehicleService.UpdateOnlySpecificProperties(car);
await vehicleService.UpdateOnlySpecificProperties(motorCycle);








