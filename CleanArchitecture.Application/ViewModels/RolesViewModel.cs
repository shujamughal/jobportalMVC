using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModels
{
    public class RolesViewModel
    {
        public RolesInfo RolesInfo { get; set; } = new RolesInfo();
        public int ExperienceInYear { get; set; }
    }
}
