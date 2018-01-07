using EventSample.SharedKernel;
using System;
using System.Collections.Generic;

namespace EventSample.Infrastructure
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        //u can add other methods...
        void Save(TEntity entity);
    }
}
