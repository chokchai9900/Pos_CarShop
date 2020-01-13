using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Pos_CarShop.Models
{
    public class cartModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string productType { get; set; }
        public string productName { get; set; }
        public string brand { get; set; }
        public double price { get; set; }
        public string discription { get; set; }
    }
}