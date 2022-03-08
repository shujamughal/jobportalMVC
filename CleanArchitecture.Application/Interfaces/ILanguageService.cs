using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ILanguageService
    {
        public LanguageViewModel GetLangViewModel();
        public List<LanguageViewModel> GetAllLangInfo();
        public Task<bool> AddLanguage(List<LanguageViewModel> languageViewModel);
        public Task<bool> DeleteLanguage(int id);
        public Task<bool> UpdateLanguage(LanguageViewModel languageViewModel);

    }
}
