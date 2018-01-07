using EventSample.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSample.Infrastructure
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly Dictionary<Guid, TEntity> _context = new Dictionary<Guid, TEntity>();       

        public void Save(TEntity entity)
        {
            _context[entity.Id] = entity;
            Console.WriteLine("Repository...");
        }
    }
}
