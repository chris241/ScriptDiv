using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace ScriptDiv.Models
{
    public class Users
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string SecurityStamp { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public List<string> Roles { get; set; }
        public string PasswordHash { get; set; }
        public List<string> Logins { get; set; }
        public List<string> Claims { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public bool Locked { get; set; }
        public bool LetUserCreatePassword { get; set; }
        public bool TpAccountAdmin { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string IdLicence { get; set; }
    }
}
