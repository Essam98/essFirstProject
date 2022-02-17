using AutoMapper;
using dotnetWithMosh.Models;
using dotnetWithMosh.Dto.Vehicles;
using System.Linq;

namespace dotnetWithMosh.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Vehicle, VehicleResource>()
                     .ForMember(v => v.Contact, opt => opt.MapFrom(vr => new ContactResours {
                         Name = vr.ContactName,
                         Email = vr.ContactEmail,
                         Phone = vr.ContactPhone, 
                     }))
                     .ForMember(v => v.Features, opt => opt.MapFrom(v => v.Features.Select(vr => vr.FeatureId)));
            
            CreateMap<VehicleResource, Vehicle>()
                     .ForMember(v => v.ContactName, opt => opt.MapFrom(vr => vr.Contact.Name))
                     .ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email))
                     .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))
                     .ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))
                     .ForMember(v => v.Features, opt => opt.MapFrom(vr => vr.Features.Select(id => new VehicleFeature { FeatureId = id })));
        }
    }
}