using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class ArtifactsFile {
        [DataMember(Name = "filename")]
        public string FileName;
        [DataMember(Name = "Size")]
        public string Size;
    }
}
