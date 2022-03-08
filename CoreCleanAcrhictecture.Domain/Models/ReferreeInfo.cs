using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models
{
    public partial class RefereeInfo:Table
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Email{ get; set; }
        public string Designation{ get; set; }
        public string WorkPlace{ get; set; }
        public int WorkExperience{ get; set; }
    }
}
