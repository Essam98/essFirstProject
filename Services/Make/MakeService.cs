using System.Threading.Tasks;
using AutoMapper;
using dotnetWithMosh.Data;
using dotnetWithMosh.Dto;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Services
{
    public class MakeService: IMakeService { 

        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public MakeService(DataContext db, IMapper mapper)
        {
            this._db = db;
            this._mapper = mapper;
        }


        public async Task<BaseResponse<Make>> Create(MakeCreate makeInput) {

            var res = new BaseResponse<Make>();
            try
            {
               Make make = new Make();
               make.Name = makeInput.Name; 

               await _db.Makes.AddAsync(make);
               await _db.SaveChangesAsync();
               
               var entity = _mapper.Map<Make>(make);
               res.Data = entity;
            }
            catch (System.Exception ex)
            {
                 res.Data = null;
                 res.ErrorCode = 500;
                 res.Message = "Something has went wrong " + ex.Message;
                 res.Success = false;
            }

            return res;
            
        } 



        
    }
    
}