using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class PersonInfo {
        [DataMember(Name = "email")]
        public string Email;

        [DataMember(Name = "name")]
        public string Name;
    }
}