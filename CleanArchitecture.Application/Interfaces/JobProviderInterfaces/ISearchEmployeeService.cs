using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.ViewModels.JobProviderViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.JobProviderInterfaces
{
    public interface ISearchEmployeeService
    {
        SearchEmployeeViewModel GetSearchEmployeeViewModel();
    }
}
