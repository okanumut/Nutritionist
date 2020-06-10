using Nutritionist.Entity.Concrete;
using Nutritionist.Entity.Context.Mongo;
using Nutritionist.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutritionist.Repository.Repositories.Mongo
{
    public class BasketsMongoRepository : MongoRepository<tbl_Basket>, IBaskets
    {
        public BasketsMongoRepository(IMongoContext context) : base(context)
        {

        }
    }
}
