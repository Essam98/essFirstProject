using AutoMapper;
using dotnetWithMosh.Dto.Modal;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Services.Modal
{
    public class ModelMapper : Profile
    {
        public ModelMapper()
        {
            CreateMap<ModelCreate, Model>();

        }
    }
}