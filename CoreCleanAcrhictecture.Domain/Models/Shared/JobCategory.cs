using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models.Shared
{
    public partial class JobCategory:Table
    {
        public int Id{ get; set; }
        public string Category{ get; set; }//i.e., remote,office,anywhere
    }

}
