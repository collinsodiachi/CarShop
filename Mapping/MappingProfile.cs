using CarShop.Models;
using AutoMapper;
using CarShop.Controllers.Resources;

namespace CarShop.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile(){
            CreateMap<Make, MakeResources>();
            CreateMap<Model, ModelResources>();
            CreateMap<Feature, FeatureResources>();
        }
    }
}