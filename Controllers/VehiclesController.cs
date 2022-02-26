using System;
using System.Threading.Tasks;
using AutoMapper;
using dotnetWithMosh.Data;
using dotnetWithMosh.Dto.Vehicles;
using dotnetWithMosh.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetWithMosh.Controllers
{
    [ApiController]
    [Route("api/vehicles")]
    public class VehiclesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly DataContext _db;


        public VehiclesController(IMapper mapper, DataContext db)
        {
            this._mapper = mapper;
            this._db = db;
        }


        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
        { 

            try
            {
                var model = await _db.Models.FindAsync(vehicleResource.ModelId);
                if (model == null)
                {
                    ModelState.AddModelError("ModelId", vehicleResource?.ModelId + " is Invalid Model Id");
                    return BadRequest(ModelState);
                }

                foreach (var feature in vehicleResource.Features)
                {
                    var featureObject = await _db.Features.FindAsync(feature);
                    if (featureObject == null)
                    {
                        ModelState.AddModelError("FeatureId", "Connot Find Feature ID with Id " + feature);
                        return BadRequest(ModelState);
                    }
                }
 
                var vehicle = _mapper.Map<VehicleResource, Vehicle>(vehicleResource);
                vehicle.LastUpdate = DateTime.Now;
                _db.Vehicles.Add(vehicle);
                await _db.SaveChangesAsync();

                var result = _mapper.Map<Vehicle, VehicleResource>(vehicle);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            } 
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle(int id, [FromBody] VehicleResource vehicleResource)
        { 

            try
            {
                var vehicle = await _db.Vehicles.FindAsync(id);
                _mapper.Map<VehicleResource, Vehicle>(vehicleResource, vehicle);
                vehicle.LastUpdate = DateTime.Now; 
                await _db.SaveChangesAsync();

                var result = _mapper.Map<Vehicle, VehicleResource>(vehicle);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            } 
        }












        
    }
}