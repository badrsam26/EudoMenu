using EudoMenu.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EudoMenu.Persistence.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly EudoMenuDbContext dbContext;

        public BaseRepository(EudoMenuDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<T> AddAsync(T item)
        {
            await dbContext.Set<T>().AddAsync(item);
            await dbContext.SaveChangesAsync();
            return item;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T item)
        {
            dbContext.Entry(item).State= EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return item;
        }
    }
}
