using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface ISkillsInfoRepository
    {
        List<SkillsInfo> GetSkillsInfos();
        Task<int> AddNewSkill(SkillsInfo skillsInfo);
        Task<bool> UpdateSkill(SkillsInfo skillsInfo);
        Task<bool> DeleteSkill(int id);

    }
}
