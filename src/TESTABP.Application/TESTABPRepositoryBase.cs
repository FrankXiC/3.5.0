using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using TESTABP.EntityFrameworkCore;

namespace TESTABP {//Base class for all repositories in my application
    public class TESTABPRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<TESTABPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey> {
        public TESTABPRepositoryBase(IDbContextProvider<TESTABPDbContext> dbContextProvider)
            : base(dbContextProvider) {
        }

        //add common methods for all repositories
    }

    //A shortcut for entities those have integer Id
    public class TESTABPRepositoryBase<TEntity> : TESTABPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int> {
        public TESTABPRepositoryBase(IDbContextProvider<TESTABPDbContext> dbContextProvider)
            : base(dbContextProvider) {
        }

        //do not add any method here, add to the class above (because this class inherits it)
    }
}
