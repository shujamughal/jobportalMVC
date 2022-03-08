using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models.Shared
{
    public partial class GenderType:Table
    {
        public int Id{ get; set; }
        public string GenderName{ get; set; }
    }
}
