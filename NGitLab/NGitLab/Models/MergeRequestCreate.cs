using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class MergeRequestCreate {
        [DataMember(Name = "assignee_id")]
        public int? AssigneeId;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "source_branch")]
        public string SourceBranch;

        [DataMember(Name = "source_project_id")]
        public int? SourceProjectId;

        [DataMember(Name = "target_branch")]
        public string TargetBranch;

        [DataMember(Name = "target_project_id")]
        public int? TargetProjectId;

        [DataMember(Name = "title")]
        public string Title;
    }
}