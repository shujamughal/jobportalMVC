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
    public class LanguageService:ILanguageService
    {
        public ILanguageInfoRepository _languageInfoRepository;
        
        public LanguageService(ILanguageInfoRepository languageInfoRepository)
        {
            _languageInfoRepository = languageInfoRepository;
        }
        public LanguageViewModel GetLangViewModel()
        {
            return new LanguageViewModel();
        }
        public List<LanguageViewModel> GetAllLangInfo()
        {
            List<LanguageViewModel> allLanguages= new List<LanguageViewModel>();
            foreach (var langInfo in _languageInfoRepository.GetLanguageInfos())
            {
                allLanguages.Add(new LanguageViewModel{ LangInfo= langInfo});
            }
            return allLanguages;
        }
        public async Task<bool> AddLanguage(List<LanguageViewModel> allLanguages)
        {
            try
            {
                int count = 0;
                foreach (var lang in allLanguages)
                {
                    int id = await _languageInfoRepository.AddNewLanguage(lang.LangInfo);
                    if (id > 0)
                        count++;
                }
                return count == allLanguages.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public async Task<bool> DeleteLanguage(int id)
        {
            return await _languageInfoRepository.DeleteLanguage(id);
        }
        public async Task<bool> UpdateLanguage(LanguageViewModel languageViewModel)
        {
            try
            {
                return await _languageInfoRepository.UpdateLanguage(languageViewModel.LangInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }



    }
}
