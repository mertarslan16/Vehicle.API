using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.API.Models;
using Vehicle.API.Repository;
using Vehicle.API.Services.Responses;
using Type = Vehicle.API.Models.Type;

namespace Vehicle.API.Services
{
    public class Service : IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id, Type type)
        {
            return await _repository.Delete(id,type);
        }

        public async Task<List<BoatResponse>> GetBoats(Color color)
        {
            var boats = await _repository.GetBoats(color);
            var boatsResponses = new List<BoatResponse>();
            boats.ForEach(
                d => boatsResponses.Add(
                    new BoatResponse{
                        Id = d.Id,
                        Color = d.Color.ToString(),
                        Type = d.Type.ToString()
                    }
                )
            );
            return boatsResponses;
        }

        public async Task<List<BusResponse>> GetBuses(Color color)
        {
            var buses = await _repository.GetBuses(color);
            var busResponses = new List<BusResponse>();
            buses.ForEach(
                d => busResponses.Add(
                    new BusResponse{
                        Id = d.Id,
                        Color = d.Color.ToString(),
                        Type = d.Type.ToString()
                    }
                )
            );
            return busResponses;
        }

        public async Task<List<CarResponse>> GetCars(Color color)
        {
            var cars = await _repository.GetCars(color);
            var carResponses = new List<CarResponse>();
            cars.ForEach(
                d => carResponses.Add(
                    new CarResponse{
                        Id = d.Id,
                        Wheel = d.Wheel,
                        Headlight = d.Headlight,
                        Color = d.Color.ToString(),
                        Type = d.Type.ToString()
                    }
                )
            );
            return carResponses;
        }

        public async Task<bool> PostCarHeadlight(Guid id)
        {
            return await _repository.PostCarHeadlight(id);
        }
    }
}