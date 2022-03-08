using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models
{
    public partial class SkillsInfo:Table
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
    }
}
