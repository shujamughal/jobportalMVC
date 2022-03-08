using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models.Shared
{
    public partial class ExperienceInfo:Table
    {
        public int Id { get; set; } = -1;
        public string ExperienceRange{ get; set; }
    }
}
