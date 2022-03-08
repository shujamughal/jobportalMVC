using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface ICRUDDbHelperRepository
    {
        public List<T> Get<T, U>(U Id, string propertyName = "Id") where T : Table;

        public Task<int> Add<T>(T item) where T : Table;

        public Task Update<T>(int Id, T item) where T : Table;

        public Task Delete<T>(int Id, string propertyName = "Id") where T : Table;
    }
}
