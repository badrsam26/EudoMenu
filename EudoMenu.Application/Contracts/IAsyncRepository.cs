using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Application.Contracts
{
    // generic interface pour manipulation de tout type de données 
    public  interface IAsyncRepository<T> where  T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> AddAsync(T item);
        Task<T> UpdateAsync(T item);
        Task DeleteAsync(int id);

    }
}
