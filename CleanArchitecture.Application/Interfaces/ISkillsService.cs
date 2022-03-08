using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ISkillsService
    {
        public SkillsViewModel GetSkillViewModel();
        public List<SkillsViewModel> GetAllSkillsInfo();
        public Task<bool> AddNewSkills(List<SkillsViewModel> skillsViewModel);
        public Task<bool> UpdateSkill(SkillsViewModel skillsViewModel);
        public Task<bool> DeleteSkill(int id);
    }
}
