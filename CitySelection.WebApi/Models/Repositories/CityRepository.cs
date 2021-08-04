using CitySelection.WebApi.Models.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySelection.WebApi.Models.Repositories
{
    public class CityRepository
    {
        private ApplicationDbContext _context;
        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<City> Get()
        {
            return _context.Cities
                .Include(x => x.Country)
                .Include(x => x.Climate);
        }

        public City Get(int id)
        {
            return _context.Cities
                .Include(x => x.Country)
                .First(x => x.Id == id);
        }

    }
}
