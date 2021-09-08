using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Vetrotech.EntityFramework.Repositories
{
    public abstract class VetrotechRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<VetrotechDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected VetrotechRepositoryBase(IDbContextProvider<VetrotechDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class VetrotechRepositoryBase<TEntity> : VetrotechRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected VetrotechRepositoryBase(IDbContextProvider<VetrotechDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
