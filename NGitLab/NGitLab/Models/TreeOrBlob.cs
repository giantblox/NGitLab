using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class TreeOrBlob {
        [DataMember(Name = "id")]
        public Sha1 Id;

        [DataMember(Name = "mode")]
        public string Mode;

        [DataMember(Name = "assets")]
        public string Name;

        [DataMember(Name = "type")]
        public ObjectType Type;
    }
}