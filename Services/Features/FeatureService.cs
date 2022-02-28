using System.Threading.Tasks;
using AutoMapper;
using dotnetWithMosh.Data;
using dotnetWithMosh.Dto.Feature;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Services.Features
{
    public class FeatureService : IFeatureService
    
    { 
        private readonly DataContext _db;
        private readonly IMapper _mapper;
        public FeatureService(IMapper mapper, DataContext db)
        {
            this._mapper = mapper;
            this._db = db;
        }


        public async Task<BaseResponse<Feature>> Create(FeatureCreate featureInput) { 
            
            var res = new BaseResponse<Feature>();
            try
            {
                Feature feature = new Feature();
                feature.Name = featureInput.Name;

                res.Data = feature;

                await _db.Features.AddAsync(feature);
                await _db.SaveChangesAsync(); 
                
            }
            catch (System.Exception ex)
            {
                 res.Data = null; 
                 res.ErrorCode = 500;
                 res.Message = "Something has went wring " + ex.Message;
                 res.Success = false; 
            }

            return res; 
        } 
    }
}