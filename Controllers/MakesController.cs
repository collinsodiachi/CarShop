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
    public class MakesController
    {
        private readonly CarShopDbContext _context;
        private readonly IMapper mapper;

        public MakesController(CarShopDbContext context, IMapper mapper)
        {
            this._context = context;
            this.mapper = mapper;
        }
        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeResources>> GetMakes(){
            var makes = await _context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResources>>(makes);
        }
    }
}