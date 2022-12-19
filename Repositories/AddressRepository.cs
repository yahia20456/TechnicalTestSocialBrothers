using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using TechnicalTestSocialBrothers.Properties.Models;

namespace TechnicalTestSocialBrothers.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AddressContext _context;
        public AddressRepository(AddressContext context)
        {
            _context = context;
        }

        public async Task<AddressInformation> Create(AddressInformation addressInformation)
        {
            _context.Adresses.Add(addressInformation);
            await _context.SaveChangesAsync();
            return addressInformation;
        }

        public async Task Delete(int id)
        {
            var AddressToDelete = await _context.Adresses.FindAsync(id);
            _context.Adresses.Remove(AddressToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AddressInformation>> Get()
        {
            return await _context.Adresses.ToListAsync();
        }

        public async Task<AddressInformation> Get(int id)
        {
            return await _context.Adresses.FindAsync(id);
        }

        public async Task Update(AddressInformation addressInformation)
        {
        _context.Entry(addressInformation).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
