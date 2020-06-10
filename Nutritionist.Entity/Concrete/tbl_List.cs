using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nutritionist.Entity.Concrete
{
    [Table("tbl_List")]
    public class tbl_List
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string _id { get; set; } = ObjectId.GenerateNewId().ToString();
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Author { get; set; }
        [StringLength(250)]
        public string Meal { get; set; }
        public string Detail { get; set; }
    }
}
