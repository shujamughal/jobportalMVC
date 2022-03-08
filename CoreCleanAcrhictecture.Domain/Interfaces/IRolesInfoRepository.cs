using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface IRolesInfoRepository
    {
        List<RolesInfo> GetRolesInfos();
        Task<int> AddNewRole(RolesInfo rolesInfo);
        Task<bool> UpdateRole(RolesInfo rolesInfo);
        Task<bool> DeleteRole(int id);

    }
}
