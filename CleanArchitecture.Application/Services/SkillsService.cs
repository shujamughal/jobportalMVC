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
    public class SkillsService:ISkillsService
    {
        public ISkillsInfoRepository _skillsInfoRepository;
        public SkillsService(ISkillsInfoRepository skillsInfoRepository)
        {
            _skillsInfoRepository = skillsInfoRepository;
        }
        public SkillsViewModel GetSkillViewModel()
        {
            return new SkillsViewModel();

        }
        public List<SkillsViewModel> GetAllSkillsInfo()
        {
            List<SkillsViewModel> allSkills = new List<SkillsViewModel>();
            foreach (var role in _skillsInfoRepository.GetSkillsInfos())
            {
                allSkills.Add(new SkillsViewModel { SkillInfo = role });
            }
            return allSkills;
        }
        public async Task<bool> AddNewSkills(List<SkillsViewModel> allSkills)
        {
            try
            {
                int count = 0;
                foreach (var skill in allSkills)
                {
                    int id = await _skillsInfoRepository.AddNewSkill(skill.SkillInfo);
                    if (id > 0)
                        count++;
                }
                return count == allSkills.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public async Task<bool> UpdateSkill(SkillsViewModel skillsViewModel)
        {
            try
            {
                return await _skillsInfoRepository.UpdateSkill(skillsViewModel.SkillInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public async Task<bool> DeleteSkill(int id)
        {
            return await _skillsInfoRepository.DeleteSkill(id);
        }
    }
}
