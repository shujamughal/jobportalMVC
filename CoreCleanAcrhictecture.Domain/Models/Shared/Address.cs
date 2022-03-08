using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models.Shared
{
    public partial class Address:Table
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; } = "";
        [ForeignKey("CityInfo")]
        public int CityID { get; set; } = -1;
        public virtual CityInfo CityInfo { get; set; } = new CityInfo();
        [ForeignKey("CountryInfo")]
        public int CountryID{ get; set; } = -1;
        public virtual CountryInfo CountryInfo{ get; set; } = new CountryInfo();
    }
}
