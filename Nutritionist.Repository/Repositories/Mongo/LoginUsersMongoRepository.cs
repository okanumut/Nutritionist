using Nutritionist.Entity.Concrete;
using Nutritionist.Entity.Context.Mongo;
using Nutritionist.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutritionist.Repository.Repositories.Mongo
{
    public class LoginUsersMongoRepository : MongoRepository<tbl_LoginUsers>, ILoginUsers
    {
        public LoginUsersMongoRepository(IMongoContext context) : base(context)
        { 
        }
    }
}
