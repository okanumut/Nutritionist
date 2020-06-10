using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Nutritionist.Entity.Concrete
{
    [Table("tbl_Basket")]
    public class tbl_Basket
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string _id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Author { get; set; }
        [StringLength(250)]
        public string Detail { get; set; }
        public string Meal { get; set; }
    }
}
