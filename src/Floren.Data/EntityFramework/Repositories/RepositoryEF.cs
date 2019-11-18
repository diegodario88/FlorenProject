using System.Collections.Generic;
using System.Threading.Tasks;
using Floren.Domain.Contracts.Repositories;
using Floren.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Floren.Data.EntityFramework.Repositories
{
    public abstract class RepositoryEF<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private FlorenDataContext _context;
        protected DbSet<TEntity> _db;

        public RepositoryEF(FlorenDataContext context)
        {
            _context = context;
            _db = _context.Set<TEntity>();
        }

        //Asíncronos
        public async Task<TEntity> GetByIdAsync(object id) => await _db.FindAsync(id);

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await _db.ToListAsync();


        //Síncronos
        public void Add(TEntity entity)
        {
            _db.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _db.Remove(entity);
            _context.SaveChanges();
        }
    }
}