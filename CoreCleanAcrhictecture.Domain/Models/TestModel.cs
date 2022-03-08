using CoreCleanAcrhictecture.Domain.Models.Shared;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models
{
    public partial class TestModel:Table
    {
        public int Id { get; set; }
        public virtual ApplicationUser ApplicationUser{ get; set; }
    }
}
