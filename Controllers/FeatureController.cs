using System.Threading.Tasks;
using dotnetWithMosh.Dto.Feature;
using dotnetWithMosh.Models;
using dotnetWithMosh.Services.Features;
using Microsoft.AspNetCore.Mvc;

namespace dotnetWithMosh.Controllers
{
    [ApiController]
    [Route("/api/feature")]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _service;
        public FeatureController(IFeatureService service)
        {
            this._service = service;
        }


        [HttpPost]
        public async Task<ActionResult<BaseResponse<Feature>>> Create(FeatureCreate feature) {
            return Ok(await _service.Create(feature));
        }




    }

}