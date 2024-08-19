using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace ApiMongoDB.Models
{
    public class Producto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nombre")]
        public string? Nombre { get; set; }
        
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("precio")]
        public decimal Precio { get; set; }

        [BsonElement("stock")]
        public int Stock { get; set; }
    }
}