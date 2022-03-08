using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CoreCleanAcrhictecture.Domain.Interfaces;
using CoreCleanAcrhictecture.Domain.Models;
using CoreCleanArchitecture.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class RefereeService:IRefereeService
    {
        public IRefereeRepository _refereeRepository;


        public RefereeViewModel GetRefereeViewModel() 
        {
            return new RefereeViewModel() { ReferreeInfo = new RefereeInfo() };
        }
        public List<RefereeViewModel> GetAllRefereesInfo() 
        {
            List<RefereeViewModel> allReferees= new List<RefereeViewModel>();
            foreach (var referee in _refereeRepository.GetRefereesInfos())
            {
                allReferees.Add(new RefereeViewModel{  ReferreeInfo = referee});
            }
            return allReferees;

        }
        public async Task<bool> AddNewReferees(List<RefereeViewModel> allreferees)
        {
            try
            {
                int count = 0;
                foreach (var referee in allreferees)
                {
                    int id = await _refereeRepository.AddNewReferee(referee.ReferreeInfo);
                    if (id > 0)
                        count++;
                }
                return count == allreferees.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        
        }
        public async Task<bool> UpdateReferee(RefereeViewModel refereeViewModel)
        {
            try
            {
                return await _refereeRepository.UpdateReferee(refereeViewModel.ReferreeInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public async Task<bool> DeleteReferee(int refereeId)
        {
            return await _refereeRepository.DeleteReferee(refereeId);
        }

    }
}
