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
                .Include(x => x.Country.Name)
                .Include(x => x.Country.GdpPerCapita)
                .Include(x => x.Country.InequalityIndex)
                .Include(x => x.Climate.Temperature24hAvgHigh)
                .Include(x => x.Climate.Temperature24hAvgLow)
                .Include(x => x.Climate.RainyDays)
                .Include(x => x.Climate.MonthlySunshineHours);
        }
    }
}
