using Nutritionist.Entity;
using Nutritionist.Entity.Context.Mongo;
using Nutritionist.Repository.Interfaces;
using Nutritionist.Repository.Repositories.Mongo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutritionist.Repository.UnitOfWork
{
    public class UnitOfWork
    {
        private bool disposed = false;
        public ILoginUsers LoginUsers { get; } 
        public IList List { get; } 
        public IBaskets Baskets { get; } 

        private readonly IMongoContext _mongoContext;

        public UnitOfWork()
        {
            if (DatabaseSelection.DatabaseType == DbType.Mongo())
            {
                _mongoContext = new MongoContext();
                LoginUsers = new LoginUsersMongoRepository(_mongoContext);
                List = new ListMongoRepository(_mongoContext);
                Baskets = new BasketsMongoRepository(_mongoContext);
            }
            else
            {

            }
        }
        public void Dispose()
        {
            if (DatabaseSelection.DatabaseType == DbType.Mongo())
            {
                _mongoContext.Dispose();
            }
            else
            {
            }


        }
        public int Save()
        {
            if (DatabaseSelection.DatabaseType == DbType.Mongo())
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public object Entity<T>()
        {
            throw new NotImplementedException();
        }
    }
}
