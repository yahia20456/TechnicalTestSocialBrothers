
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TechnicalTestSocialBrothers.Properties.Models;
using TechnicalTestSocialBrothers.Repositories;


namespace TechnicalTestSocialBrothers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepository addressRepository;
        private readonly AddressContext addresscontext;
       
        public AddressController(IAddressRepository addressRepository,AddressContext addressContext)
        {
            this.addressRepository = addressRepository;
            this.addresscontext = addressContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressInformation>>> GetAddresses( string search,  string sort,  bool isAscending)
        {
            var addressCollection = await addresscontext.Adresses.ToListAsync();//All addresses from database
            var filteredAddresses = new List<AddressInformation>();//empty list
            var addressProperties = typeof(AddressInformation).GetProperties();//all my properties (city,zip code ...)
            if (search != null)
            {
                
                foreach (AddressInformation address in addressCollection)//loop adress from db
                {
                    foreach (PropertyInfo propertyInfo in addressProperties)
                    {
                        if (propertyInfo.GetValue(address).ToString().Contains(search))
                        {
                            filteredAddresses.Add(address);
                            break;
                        }
                    }
                }
            }
            else
            {
                filteredAddresses = addressCollection;//rrken search null tjib les adress il kol mil db
            }
            var sortedAddresses = new List<AddressInformation>();
            if (typeof(AddressInformation).GetProperties().Any(p=>p.Name==sort))//aa
            {
                sortedAddresses = filteredAddresses.OrderBy(x => x.GetType().GetProperty(sort).GetValue(x, null)).ToList();

                if (isAscending.Equals(false))
                {
                    sortedAddresses.Reverse();
                }

            }
            

            return sortedAddresses;
        }

            [HttpGet("{id}")]
        public async Task<ActionResult<AddressInformation>> GetAddress(int id)
        {
            return await addressRepository.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<AddressInformation>> PostAddress([FromBody] AddressInformation addressInformation) {
            var newAddress = await addressRepository.Create(addressInformation);
            return CreatedAtAction(nameof(GetAddress),new { id = newAddress.Id}, newAddress);
        }
        [HttpPut]
        public async Task<ActionResult> PutAddress(int id, [FromBody] AddressInformation addressInformation) {
            if(id != addressInformation.Id)
            {
                return BadRequest();
            }

            await addressRepository.Update(addressInformation);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var addressToDelete = await addressRepository.Get(id);
            if(addressToDelete == null) 
                return NotFound();
            await addressRepository.Delete(addressToDelete.Id); 
            return NoContent();
        }
    }
   
}
