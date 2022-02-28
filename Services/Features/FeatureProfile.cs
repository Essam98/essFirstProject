using AutoMapper;
using dotnetWithMosh.Dto.Feature;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Services.Features
{
    public class FeatureProfile : Profile
    {
        public FeatureProfile()
        {
            CreateMap<FeatureCreate, Feature>();
        }
    }
}