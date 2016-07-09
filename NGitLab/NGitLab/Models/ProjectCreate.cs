using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class ProjectCreate {
        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "import_url")]
        public string ImportUrl;

        [DataMember(Name = "issues_enabled")]
        public bool IssuesEnabled;

        [DataMember(Name = "merge_requests_enabled")]
        public bool MergeRequestsEnabled;

        [Required]
        [DataMember(Name = "name")]
        public string Name;

        [Required]
        [DataMember(Name = "namespace_id")]
        public string NamespaceId;

        [DataMember(Name = "path")]
        public string Path;

        [DataMember(Name = "snippets_enabled")]
        public bool SnippetsEnabled;

        [DataMember(Name = "visibility_level")]
        public VisibilityLevel VisibilityLevel;

        [DataMember(Name = "wall_enabled")]
        public bool WallEnabled;

        [DataMember(Name = "wiki_enabled")]
        public bool WikiEnabled;
    }
}