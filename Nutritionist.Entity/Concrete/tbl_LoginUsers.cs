using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nutritionist.Entity.Concrete
{
    [Table("tbl_LoginUsers")]
    public class tbl_LoginUsers
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string _id { get; set; } = ObjectId.GenerateNewId().ToString();
        [StringLength(20)]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
