using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptDiv.Models
{
    public class TpAccount
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string AdminUserId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string LicenceId { get; set; }
        public string Organization { get; set; }
        public string TriggerCode { get; set; }
        public string AccountOwnerFirstname { get; set; }
        public string AccountOwnerLastname { get; set; }
        public string AssociatedEmail { get; set; }
        public int UserLimit { get; set; }
        public string TriggerKey { get; set; }
        public bool SpaceStatus { get; set; }
    }
}
