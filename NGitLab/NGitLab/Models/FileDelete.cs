using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class FileDelete {
        [Required]
        [DataMember(Name = "branch_name")]
        public string Branch;

        [Required]
        [DataMember(Name = "commit_message")]
        public string CommitMessage;

        [Required]
        [DataMember(Name = "file_path")]
        public string Path;
    }
}