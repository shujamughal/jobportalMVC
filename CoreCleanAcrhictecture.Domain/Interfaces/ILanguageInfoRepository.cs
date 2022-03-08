using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface ILanguageInfoRepository
    {
        List<LanguageInfo> GetLanguageInfos();
        Task<int> AddNewLanguage(LanguageInfo languageInfo);
        Task<bool> UpdateLanguage(LanguageInfo languageInfo);
        Task<bool> DeleteLanguage(int id);

    }
}
