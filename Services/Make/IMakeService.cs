using System.Threading.Tasks;
using dotnetWithMosh.Dto;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Services
{
    public interface IMakeService {


        Task<BaseResponse<Make>> Create(MakeCreate make);
    }
}