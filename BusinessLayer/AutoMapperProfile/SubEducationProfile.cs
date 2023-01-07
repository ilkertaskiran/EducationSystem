using AutoMapper;
using BusinessLayer.Dto;
using DataLayer.Model;

namespace BusinessLayer.AutoMapperProfile;
public class SubEducationProfile : Profile
{
    public SubEducationProfile()
    {
        CreateMap<SubEducationDto, SubEducation>();
        //CreateMap<ProductDto, Product>().ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Name)).ForMember(dest => dest.ProductId, opt => opt.Ignore());
        //CreateMap<Product, ProductDto>().ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ProductName));
        //Enum.GetName(typeof(EnumDisplayStatus), value)
    }
}