using System.Threading.Tasks;
using dotnetWithMosh.Dto.Modal;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Services.Modal
{
    public interface IModalService
    {
        Task<BaseResponse<Model>> Create(ModelCreate modale);
    }
}