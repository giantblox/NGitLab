using System;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class Namespace {
        public const string Url = "/groups";

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "owner_id")]
        public int? OwnerId;

        [DataMember(Name = "path")]
        public string Path;

        [DataMember(Name = "updated_at")]
        public DateTime UpdatedAt;
    }
}