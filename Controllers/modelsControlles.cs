using System.Threading.Tasks;
using dotnetWithMosh.Data;
using dotnetWithMosh.Dto.Modal;
using dotnetWithMosh.Models;
using dotnetWithMosh.Services.Modal;
using Microsoft.AspNetCore.Mvc;

namespace dotnetWithMosh.Controllers
{
    [ApiController]
    [Route("api/models")]
    public class modelsControlles : ControllerBase
    {

        private readonly DataContext _db;
        private readonly IModalService _service;
        public modelsControlles(DataContext db, IModalService service)
        {
            this._db = db;
            this._service = service;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<BaseResponse<Model>>> Create(ModelCreate modal) {
            return  Ok(await _service.Create(modal));
        }


        
    }
}