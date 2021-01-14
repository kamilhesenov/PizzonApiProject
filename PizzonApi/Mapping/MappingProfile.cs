using AutoMapper;
using Data.Entities;
using PizzonApi.Resources.HomePage;

namespace PizzonApi.Mapping
{
    public class MappingProfile: Profile
    {
        private static string BaseUrl = "https://localhost:44323/img/";
        public MappingProfile()
        {
            CreateMap<Banner, BannerResource>()
                .ForMember(d => d.PhotoUrl, opt => opt.MapFrom(src => BaseUrl + src.PhotoUrl));
        }
    }
}
