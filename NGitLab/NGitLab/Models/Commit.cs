using System;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class Commit {
        public const string Url = "/commits";

        [DataMember(Name = "author_email")]
        public string AuthorEmail;

        [DataMember(Name = "author_name")]
        public string AuthorName;

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt;

        [DataMember(Name = "id")]
        public Sha1 Id;

        [DataMember(Name = "short_id")]
        public string ShortId;

        [DataMember(Name = "title")]
        public string Title;
    }
}