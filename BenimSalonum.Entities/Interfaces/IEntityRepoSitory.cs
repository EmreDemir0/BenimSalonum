using System;
using System.Linq.Expressions;
using System.Data.Entity;

namespace BenimSalonum.Entities.Interfaces
{
    public interface IEntityRepoSitory<TContext,TEntity> 
        where TContext:DbContext ,new()
        where TEntity:class,IEntity,new()
    {
        bool AddOrUpDate(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter); 
        void Save(TContext context);
    }
}
