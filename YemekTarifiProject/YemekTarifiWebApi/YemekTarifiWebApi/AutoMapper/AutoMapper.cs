using AutoMapper;
using YemekTarifiWebApi.Dto;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<UserDto, User>();
            CreateMap<CategoryDto, Category>();
            CreateMap<CommentDto, Comment>();
            CreateMap<ProductDto, Product>();
        }
    //      .ForMember(
    //    dest => dest.Name,
    //    opt => opt.MapFrom(src => src.Name))
    //    .ForMember(
    //    dest => dest.Surname,
    //    opt => opt.MapFrom(src => src.Surname))
    //    .ForMember(
    //    dest => dest.Email,
    //    opt => opt.MapFrom(src => src.Email))
    //     .ForMember(
    //    dest => dest.IsDeleted,
    //    opt => opt.MapFrom(src => src.IsDeleted))
    //      .ForMember(
    //    dest => dest.LastModifiedDate,
    //    opt => opt.MapFrom(src => src.LastModifiedDate))
    //      .ForMember(
    //    dest => dest.CreationDate,
    //    opt => opt.MapFrom(src => src.CreationDate))
    //      .ForMember(
    //    dest => dest.Gender,
    //    opt => opt.MapFrom(src => src.Gender))
    //      .ForMember(
    //    dest => dest.Password,
    //    opt => opt.MapFrom(src => src.Password))
    }
}
