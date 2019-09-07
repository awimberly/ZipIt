using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZipIt.Models
{
    public class City
    {
        [Key]
        public string Zip { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public string CityName { get; set; }
        public string StateId { get; set; }
        public string StateName { get; set; }
        public string TimeZone { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
