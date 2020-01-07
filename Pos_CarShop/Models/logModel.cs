using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos_CarShop.Models
{
    public class logModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime TradinDate { get; set; }
        public double sumPrice { get; set; }
        public List<saleProductModel> saleProducts { get; set; }
    }
}
