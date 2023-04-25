using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.API.Models;
using Type = Vehicle.API.Models.Type;

namespace Vehicle.API.Repository
{
    public class Repository : IRepository
    {
        private readonly VehicleContext _context;
        public Repository(VehicleContext context)
        {
            _context = context;
        }
        public async Task<bool> Delete(Guid id, Type type)
        {
            if (type == Type.Car){
                var car = _context.Cars.SingleOrDefault(s => s.Id == id);
                if (car is not null){
                    _context.Cars.Remove(car);
                    _context.SaveChanges();
                    return true;
                }
            }
            if ( type == Type.Bus){
                var bus = _context.Buses.SingleOrDefault(s => s.Id == id);
                if (bus is not null){
                    _context.Buses.Remove(bus);
                    _context.SaveChanges();
                    return true;
                }
            }
            if( type == Type.Boat){
                var boat = _context.Boats.SingleOrDefault(s => s.Id == id);
                if (boat is not null){
                    _context.Boats.Remove(boat);
                    _context.SaveChanges();
                    return true;
                }
            } 
            return false;
        }

        public async Task<List<Boat>> GetBoats(Color color)
        {
            var boats = _context.Boats.Where(s => s.Color == color).ToList();
            if (boats.Any()){
                return boats;
            }
            return new List<Boat>();
        }

        public async Task<List<Bus>> GetBuses(Color color)
        {
            var buses = _context.Buses.Where(s => s.Color == color).ToList();
            if (buses.Any()){
                return buses;
            }
            return new List<Bus>();
        }

        public async Task<List<Car>> GetCars(Color color)
        {
            var cars = _context.Cars.Where(s => s.Color == color).ToList();
            if (cars.Any()){
                return cars;
            }
            return new List<Car>();
        }

        public async Task<bool> PostCarHeadlight(Guid id)
        {
            var car = _context.Cars.SingleOrDefault(s => s.Id == id);
            if (car is not null){
                if (car.Headlight){
                    car.Headlight = false;
                }
                else {
                    car.Headlight = true;
                }
                _context.Update(car);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}