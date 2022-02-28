using System.Threading.Tasks;
using dotnetWithMosh.Dto.Feature;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Services.Features
{
    public interface IFeatureService
    {
         Task<BaseResponse<Feature>> Create(FeatureCreate featureInput);
    }
}