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
        public async Task<IActionResult>  CreateVehicle([FromBody] VehicleResource vehicleResource) {

            // if (ModelState.IsValid) 
                // return BadRequest(ModelState);
            
            // var model = await _db.Models.FindAsync(vehicleResource.ModelId);
            // if (model == null) {
                // ModelState.AddModelError("ModelId", "Invalid Model Id");
                // return BadRequest(ModelState);
            // }
            
            var vehicle = _mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            _db.Vehicles.Add(vehicle);
            await _db.SaveChangesAsync();

            var result = _mapper.Map<Vehicle, VehicleResource>(vehicle);
            return Ok(result);
        }
    }
}