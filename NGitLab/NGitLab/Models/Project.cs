using System;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class Project {
        public const string Url = "/projects";

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt;

        [DataMember(Name = "default_branch")]
        public string DefaultBranch;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "http_url_to_repo")]
        public string HttpUrl;

        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "issues_enabled")]
        public bool IssuesEnabled;

        [DataMember(Name = "merge_requests_enabled")]
        public bool MergeRequestsEnabled;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "namespace")]
        public Namespace Namespace;

        [DataMember(Name = "owner")]
        public User Owner;

        [DataMember(Name = "path")]
        public string Path;

        [DataMember(Name = "path_with_namespace")]
        public string PathWithNamespace;

        [DataMember(Name = "public")]
        public bool Public;

        [DataMember(Name = "ssh_url_to_repo")]
        public string SshUrl;

        [DataMember(Name = "wall_enabled")]
        public bool WallEnabled;

        [DataMember(Name = "wiki_enabled")]
        public bool WikiEnabled;

        [DataMember(Name = "tag_list")]
        public string[] Tags;
    }
}