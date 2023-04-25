using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vehicle.API.Repository;

namespace Vehicle.API.Helpers
{
    public static class DataJob
    {
        public static void Initialize(IServiceProvider serviceProvider){
            using(var context = new VehicleContext(serviceProvider.GetRequiredService<DbContextOptions<VehicleContext>>())){
                if(context.Cars.Any() || context.Buses.Any() || context.Boats.Any()){
                    return;
                }
                context.Cars.AddRange(
                    new Models.Car{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120001"),Color = Models.Color.Blue,Headlight = false,Type = Models.Type.Car,Wheel = 4},
                    new Models.Car{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120002"),Color = Models.Color.Blue,Headlight = false,Type = Models.Type.Car,Wheel = 4},
                    new Models.Car{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120003"),Color = Models.Color.Red,Headlight = false,Type = Models.Type.Car,Wheel = 4},
                    new Models.Car{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120004"),Color = Models.Color.Red,Headlight = false,Type = Models.Type.Car,Wheel = 4},
                    new Models.Car{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120005"),Color = Models.Color.Black,Headlight = false,Type = Models.Type.Car,Wheel = 4},
                    new Models.Car{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120006"),Color = Models.Color.White,Headlight = false,Type = Models.Type.Car,Wheel = 4},
                    new Models.Car{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120007"),Color = Models.Color.Blue,Headlight = false,Type = Models.Type.Car,Wheel = 4}
                );
                context.Buses.AddRange(
                    new Models.Bus{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120001"),Color = Models.Color.Blue,Type = Models.Type.Bus},
                    new Models.Bus{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120002"),Color = Models.Color.Blue,Type = Models.Type.Bus},
                    new Models.Bus{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120003"),Color = Models.Color.Red,Type = Models.Type.Bus},
                    new Models.Bus{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120004"),Color = Models.Color.Red,Type = Models.Type.Bus},
                    new Models.Bus{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120005"),Color = Models.Color.Black,Type = Models.Type.Bus},
                    new Models.Bus{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120006"),Color = Models.Color.White,Type = Models.Type.Bus},
                    new Models.Bus{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120007"),Color = Models.Color.Blue,Type = Models.Type.Bus}
                );
                context.Boats.AddRange(
                    new Models.Boat{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120001"),Color = Models.Color.Blue,Type = Models.Type.Boat},
                    new Models.Boat{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120002"),Color = Models.Color.Blue,Type = Models.Type.Boat},
                    new Models.Boat{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120003"),Color = Models.Color.Red,Type = Models.Type.Boat},
                    new Models.Boat{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120004"),Color = Models.Color.Red,Type = Models.Type.Boat},
                    new Models.Boat{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120005"),Color = Models.Color.Black,Type = Models.Type.Boat},
                    new Models.Boat{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120006"),Color = Models.Color.White,Type = Models.Type.Boat},
                    new Models.Boat{Id =Guid.Parse("275ec7d0-e37d-11ed-b5ea-0242ac120007"),Color = Models.Color.Blue,Type = Models.Type.Boat}
                );
                context.SaveChanges();

            }
        }
    }
}