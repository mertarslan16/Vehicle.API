using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vehicle.API.Models;
using Vehicle.API.Services;
using Type = Vehicle.API.Models.Type;

namespace Vehicle.API.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    private readonly IService _service;

    public VehicleController(IService service)
    {
        _service = service;
    }

    [HttpGet("car")]
    public async Task<IActionResult> GetCar([FromQuery] Color color){
        var cars = await _service.GetCars(color);
        return Ok(cars);
    }

    [HttpGet("bus")]
    public async  Task<IActionResult> GetBus([FromQuery] Color color){
        var buses = await _service.GetBuses(color);
        return Ok(buses);
    }

    [HttpGet("boat")]
    public async Task<IActionResult> GetBoat([FromQuery] Color color){
        var boats = await _service.GetBoats(color);
        return Ok(boats);
    }

    [HttpPost("car/{id}")]
    public async Task<IActionResult> PostCarHeadlight(Guid id){
        var result = await _service.PostCarHeadlight(id);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id,Type type){
        var result = await _service.Delete(id,type);
        return Ok(result);
    }
}