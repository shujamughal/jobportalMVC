using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IRolesService
    {
        public RolesViewModel GetRolesViewModel();
        public List<RolesViewModel> GetAllRolesInfo();
        public Task<bool> AddNewRoles(List<RolesViewModel> roles);
        public Task<bool> UpdateRole(RolesViewModel rolesViewModel);
        public Task<bool> DeleteRole(int id);
    }
}
