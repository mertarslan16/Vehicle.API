using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.API.Models;
using Vehicle.API.Services.Responses;
using Type = Vehicle.API.Models.Type;

namespace Vehicle.API.Services
{
    public interface IService
    {
        Task<List<CarResponse>> GetCars(Color color);
        Task<List<BusResponse>> GetBuses(Color color);
        Task<List<BoatResponse>> GetBoats(Color color);
        Task<bool> PostCarHeadlight(Guid id);
        Task<bool> Delete(Guid id, Type type);
    }
}