using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiMongoDB.Models
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        
        [BsonElement("nombre")]
        public String? Nombre { get; set; }


        [BsonElement("nombreUsuario")]
        public String? NombreUsuario { get; set; }

        [BsonElement("pwd")]
        public String? Pwd { get; set; }
    }
}