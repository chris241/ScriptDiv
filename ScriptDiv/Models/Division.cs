using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDiv.Models
{
    public class Division
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string DivisionNom { get; set; }
        public string IdLicence { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string DivisionParentId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }
    }
}
