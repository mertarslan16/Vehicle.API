using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.API.Models;
using Type = Vehicle.API.Models.Type;

namespace Vehicle.API.Repository
{
    public interface IRepository
    {
        Task<List<Car>> GetCars(Color color);
        Task<List<Bus>> GetBuses(Color color);
        Task<List<Boat>> GetBoats(Color color);
        Task<bool> PostCarHeadlight(Guid id);
        Task<bool> Delete(Guid id, Type type);

    }
}