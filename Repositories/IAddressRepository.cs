using TechnicalTestSocialBrothers.Properties.Models;

namespace TechnicalTestSocialBrothers.Repositories
{
    public interface IAddressRepository
    {
        Task<IEnumerable<AddressInformation>> Get();
        Task<AddressInformation> Get(int id);
        Task<AddressInformation> Create(AddressInformation addressInformation);
        Task Update(AddressInformation addressInformation);
        Task Delete(int id);
    }
}
