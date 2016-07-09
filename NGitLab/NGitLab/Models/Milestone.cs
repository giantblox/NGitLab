using System;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class Milestone {
        [DataMember(Name = "created_at")]
        public DateTime CreatedAt;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "due_date")]
        public string DueDate;

        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "state")]
        public string State;

        [DataMember(Name = "title")]
        public string Title;

        [DataMember(Name = "updated_at")]
        public DateTime UpdatedAt;
    }
}