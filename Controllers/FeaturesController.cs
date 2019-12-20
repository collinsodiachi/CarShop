using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CarShop.Controllers.Resources;
using CarShop.Models;
using CarShop.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Controllers
{
    public class FeaturesController
    {
        private readonly CarShopDbContext _context;
        private readonly IMapper mapper;

        public FeaturesController(CarShopDbContext context, IMapper mapper)
        {
            this._context = context;
            this.mapper = mapper;
        }
        [HttpGet("api/features")]
        public async Task<IEnumerable<FeatureResources>> GetFeatures(){
            var features = await _context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<FeatureResources>>(features);
        }
    }
}