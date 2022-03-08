using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CoreCleanAcrhictecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class RolesService:IRolesService
    {
        public IRolesInfoRepository _rolesInfoRepository;
        
        public RolesService(IRolesInfoRepository rolesInfoRepository)
        {
            _rolesInfoRepository = rolesInfoRepository;
        }
        public RolesViewModel GetRolesViewModel()
        {
            return new RolesViewModel();

        }
        public List<RolesViewModel> GetAllRolesInfo()
        {
            List<RolesViewModel> allRoles= new List<RolesViewModel>();
            foreach (var role in _rolesInfoRepository.GetRolesInfos())
            {
                allRoles.Add(new RolesViewModel { RolesInfo= role});
            }
            return allRoles;
        }
        public async Task<bool> AddNewRoles(List<RolesViewModel> allRoles)
        {
            try
            {
                int count = 0;
                foreach (var role in allRoles)
                {
                    int id = await _rolesInfoRepository.AddNewRole(role.RolesInfo);
                    if (id > 0)
                        count++;
                }
                return count == allRoles.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public async Task<bool> UpdateRole(RolesViewModel rolesViewModel)
        {
            try
            {
                return await _rolesInfoRepository.UpdateRole(rolesViewModel.RolesInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public async Task<bool> DeleteRole(int id)
        {
            return await _rolesInfoRepository.DeleteRole(id);
        }

    }
}