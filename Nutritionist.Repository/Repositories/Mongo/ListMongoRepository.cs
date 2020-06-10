using Nutritionist.Entity.Concrete;
using Nutritionist.Entity.Context.Mongo;
using Nutritionist.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutritionist.Repository.Repositories.Mongo
{
    public class ListMongoRepository : MongoRepository<tbl_List>, IList
    {
        public ListMongoRepository(IMongoContext context) : base(context)
        {
        }
    }
} 
