using AutoMapper;
using dotnetWithMosh.Dto;
using dotnetWithMosh.Models;

namespace dotnetWithMosh.Services
{
    public class MakeMapper: Profile {

        public MakeMapper()
        {
            CreateMap<MakeCreate, Make>();
        }
        
    }
}