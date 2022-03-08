using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface IRefereeRepository
    {
        public List<RefereeInfo> GetRefereesInfos();
        public Task<int> AddNewReferee(RefereeInfo referreeInfo);
        public Task<bool> UpdateReferee(RefereeInfo referreeInfo);
        public Task<bool> DeleteReferee(int id);

    }
}
