using System.IO.Compression;

namespace TechnicalTestSocialBrothers.Properties.Models
{
    public class AddressInformation
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
