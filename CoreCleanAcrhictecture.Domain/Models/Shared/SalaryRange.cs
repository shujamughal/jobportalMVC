using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models.Shared
{
    public partial class SalaryRange:Table
    {
        public int Id{ get; set; }
        public string SalRange{ get; set; }
    }
}
