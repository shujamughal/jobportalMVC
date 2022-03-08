using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models
{
    public partial class LanguageInfo:Table
    {
        public int Id { get; set; }
        public string Lang_Name { get; set; }
    }
}
