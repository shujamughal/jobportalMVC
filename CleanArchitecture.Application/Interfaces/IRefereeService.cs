using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    interface IRefereeService
    {
        public RefereeViewModel GetRefereeViewModel();
        public List<RefereeViewModel> GetAllRefereesInfo();
        public Task<bool> AddNewReferees(List<RefereeViewModel> refereeViewModel);
        public Task<bool> UpdateReferee(RefereeViewModel refereeViewModel);
        public Task<bool> DeleteReferee(int ReferreeId);

    }
}
