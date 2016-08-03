using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class ProjectHookUpsert {
        [DataMember(Name = "merge_requests_events")]
        public bool MergeRequestsEvents;

        [DataMember(Name = "push_events")]
        public bool PushEvents;

        [DataMember(Name = "build_events")]
        public bool BuildEvents;

        [DataMember(Name = "enable_ssl_verification")]
        public bool EnableSSLVerification;

        [Required]
        [DataMember(Name = "url")]
        public Uri Url;
    }
}