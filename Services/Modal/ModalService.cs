using System.Threading.Tasks;
using AutoMapper;
using dotnetWithMosh.Data;
using dotnetWithMosh.Dto.Modal;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Services.Modal
{
    public class ModalService: IModalService
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;
        public ModalService(IMapper mapper, DataContext db)
        {
            this._mapper = mapper;
            this._db = db;
        }


        public async Task<BaseResponse<Model>> Create(ModelCreate modal) {

            var res = new BaseResponse<Model>();

            try {
                Model model = new Model();
                model.Name = modal.Name;

                var entity = _mapper.Map<Model>(modal);
                await _db.Models.AddAsync(entity);
                await _db.SaveChangesAsync();
            }
            catch (System.Exception ex)
            { 
                res.Data = null;
                res.Success = false;
                res.Message = "Something has went wrong " + ex.Message;
                res.ErrorCode = 500;
            }
            
            return res;
        }



    }
}