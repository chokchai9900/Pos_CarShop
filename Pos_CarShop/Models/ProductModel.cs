using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_CarShop.Models
{
    public class ProductModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string productType { get; set; }
        public string productName { get; set; }
        public string brand { get; set; }
        public int countProduct { get; set; }
        public double price { get; set; }
        public string discription { get; set; }
    }
}
