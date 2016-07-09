using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class NamespaceCreate {
        [DataMember(Name = "description")]
        public string Description;

        [Required]
        [DataMember(Name = "name")]
        public string Name;

        [Required]
        [DataMember(Name = "path")]
        public string Path;
    }
}