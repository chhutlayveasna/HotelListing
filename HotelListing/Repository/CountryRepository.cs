using AutoMapper;
using HotelListing.Contracts;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;

        public CountryRepository(HotelListingDbContext context, IMapper mapper) : base(context, mapper)
        {
            this._context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _context.Countries.Include(c => c.Hotels).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
