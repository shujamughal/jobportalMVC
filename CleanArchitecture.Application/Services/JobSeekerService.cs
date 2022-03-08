using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CoreCleanAcrhictecture.Domain.Interfaces;
using CoreCleanAcrhictecture.Domain.Models;
using CoreCleanAcrhictecture.Domain.Models.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class JobSeekerService : IJobSeekerService
    {
        public IJobSeekerRepository _jobSeekerRepository;
        public ISkillsInfoRepository _skillsInfoRepository;
        public IRolesInfoRepository _rolesInfoRepository;
        public IJobSeekerRolesRepository _jobSeekerRolesRepository;
        public IJobSeekerSkillsRepository _jobSeekerSkillsRepository;
        public IEducationInstituteInfoRepository _educationInstituteInfoRepository;
        public ICitiesRepository _citiesRepository;
        public ICRUDDbHelperRepository _CRUDDbHelperRepository;

        public JobSeekerService(ICRUDDbHelperRepository CRUDDbHelperRepository, IJobSeekerRepository jobSeekerRepository, IJobSeekerSkillsRepository jobSeekerSkillsRepository, IJobSeekerRolesRepository jobSeekerRolesRepository, ISkillsInfoRepository skillsInfoRepository, IRolesInfoRepository rolesInfoRepository, IEducationInstituteInfoRepository educationInstituteInfoRepository, ICitiesRepository citiesRepository)
        {
            _citiesRepository = citiesRepository;
            _jobSeekerRepository = jobSeekerRepository;
            _jobSeekerRolesRepository = jobSeekerRolesRepository;
            _jobSeekerSkillsRepository = jobSeekerSkillsRepository;
            _rolesInfoRepository = rolesInfoRepository;
            _skillsInfoRepository = skillsInfoRepository;
            _educationInstituteInfoRepository = educationInstituteInfoRepository;
            _CRUDDbHelperRepository = CRUDDbHelperRepository;
        }
        public JobSeekerViewModel GetJobSeekerById(int id)
        {
            JobSeekerViewModel jobSeeker = new JobSeekerViewModel();
            jobSeeker.JobSeeker = _jobSeekerRepository.GetJobSeekers().Where(js => js.Id == id).First();//extracting particular ID job seeker personal info

            jobSeeker.JobSeekerRoles = _jobSeekerRolesRepository.GetJobSeekerRolesInfo(id);//extracting particular ID job seeker Roles Info
            jobSeeker.JobSeekerSkills = _jobSeekerSkillsRepository.GetJobSeekerSkillsInfo(id);//extracting particular ID job seeker Skills Info
            return jobSeeker;
        }
        public JobSeekerSignUpViewModel GetJobSeekerViewModel()
        {
            JobSeekerSignUpViewModel jobSeekerSignUpViewModel = new JobSeekerSignUpViewModel()
            { 
                AllInstitutes = _CRUDDbHelperRepository.Get<EducationInstituteInfo,int>(0),
                AllSkills = _CRUDDbHelperRepository.Get<SkillsInfo,int>(0),
                AllRoles = _CRUDDbHelperRepository.Get<RolesInfo,int>(0),
                AllCities=_CRUDDbHelperRepository.Get<CityInfo,int>(0),
                CareerLevels=_CRUDDbHelperRepository.Get<CareerLevel,int>(0),
                GenderTypes=_CRUDDbHelperRepository.Get<GenderType,int>(0),
                JobCategories=_CRUDDbHelperRepository.Get<JobCategory,int>(0),
                SalaryRanges=_CRUDDbHelperRepository.Get<SalaryRange,int>(0)
            };
            for (int i = 0; i < jobSeekerSignUpViewModel.JobSeekerSkills.Length; i++)
            {
                jobSeekerSignUpViewModel.JobSeekerSkills[i] = new CoreCleanAcrhictecture.Domain.Models.JobSeekerSkills();
            }
            for (int i = 0; i < jobSeekerSignUpViewModel.JobSeekerRoles.Length; i++)
            {
                jobSeekerSignUpViewModel.JobSeekerRoles[i] = new CoreCleanAcrhictecture.Domain.Models.JobSeekerRoles();
            }
            return jobSeekerSignUpViewModel;
        }
        public async Task<bool> AddJobSeeker(JobSeekerSignUpViewModel jobSeekerViewModel)
        {
            //this will return the Id of newly added object beck to the view
            jobSeekerViewModel.JobSeeker.ResumePath = GetResumeFilePath(jobSeekerViewModel.ResumeFile, true);

//            int id = await _CRUDDbHelperRepository.Add<JobSeeker>(jobSeekerViewModel.JobSeeker);
            int id = await _jobSeekerRepository.AddJobSeeker(jobSeekerViewModel.JobSeeker);
            bool isSkillsAded = await _jobSeekerSkillsRepository.AddJobSeekerSkills(jobSeekerViewModel.JobSeekerSkills.ToList(), id);
            bool isRolesAdded = await _jobSeekerRolesRepository.AddJobSeekerRoles(jobSeekerViewModel.JobSeekerRoles.ToList(), id);
            return id!=-1 && isSkillsAded && isRolesAdded;
        }
        public async Task<bool> DeleteJobSeeker(int id)
        {
            return await _jobSeekerRepository.DeleteJobSeeker(id);
            //this will return a bool value indicating whether or not the JobSeeker has been deleted ?
        }
        public async Task<bool> UpdateJobSeeker(JobSeekerSignUpViewModel jobSeekerViewModel)
        {
            try
            {
                bool status = await _jobSeekerRepository.UpdateJobSeeker(jobSeekerViewModel.JobSeeker);
                status = await _jobSeekerSkillsRepository.UpdateJobSeekerSkills(jobSeekerViewModel.JobSeeker.Id, jobSeekerViewModel.JobSeekerSkills.ToList());
                status = await _jobSeekerRolesRepository.UpdateJobSeekerRoles(jobSeekerViewModel.JobSeeker.Id, jobSeekerViewModel.JobSeekerRoles.ToList());
                return true;
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        static public string GetResumeFilePath(IFormFile resumeFile, bool isSaveRequired)
        {
            if (resumeFile != null)
            {
                String fileName = Path.GetFileNameWithoutExtension(resumeFile.FileName);
                String extension = Path.GetExtension(resumeFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                fileName = fileName.Replace('+', '-');
                String imagePath = "~/Resumes/" + fileName;
                if (isSaveRequired)
                {
                    string resumeNameStoredInFolder = fileName;
                    resumeNameStoredInFolder = Path.Combine(Path.Combine((string)AppDomain.CurrentDomain.GetData("WebRootPath"), "Resumes"), fileName);
                    using (var stream = File.Open(resumeNameStoredInFolder, FileMode.Create, FileAccess.Write))
                    {
                        resumeFile.CopyTo(stream);
                    }
                }
                return imagePath;
            }
            else
                return null;
        }
    }
}
