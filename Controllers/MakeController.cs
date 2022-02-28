using System.Threading.Tasks;
using dotnetWithMosh.Data;
using dotnetWithMosh.Dto; 
using dotnetWithMosh.Models;
using dotnetWithMosh.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnetWithMosh.Controllers
{
    [ApiController]
    [Route("api/Make")]
    public class MakeController: ControllerBase {

        private readonly DataContext _db;
        private readonly IMakeService _service;

        public MakeController(DataContext db, IMakeService service)
        {
            this._service = service;
            this._db = db;
        }
        [HttpPost]
        public async Task<ActionResult<BaseResponse<Make>>> Create(MakeCreate make) {
            return Ok(await _service.Create(make));
        }
        
    } 
}