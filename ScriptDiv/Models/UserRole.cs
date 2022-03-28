using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ScriptDiv.Models
{
    public class UserRole
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string TpAccountId { get; set; }
        public bool ContactManagerViewer { get; set; }
        public bool ContactManagerEditor { get; set; }
        public bool ReportManagerViewer { get; set; }
        public bool ReportManagerEditor { get; set; }
        public bool AssetManagerViewer { get; set; }
        public bool AssetManagerEditor { get; set; }
        public bool AlertManagerViewer { get; set; }
        public bool AlertManagerEditor { get; set; }
        public bool VehicleManagerViewer { get; set; }
        public bool VehicleManagerEditor { get; set; }
        public bool HorizonManagerViewer { get; set; }
    }
}
