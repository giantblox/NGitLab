using System;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class Build {
        public const string Url = "/builds";

        [DataMember(Name = "commit")]
        public Commit Commit;

        [DataMember(Name = "created_at")]
        public DateTime? CreatedAt;

        [DataMember(Name = "started_at")]
        public DateTime? StartedAt;

        [DataMember(Name = "finished_at")]
        public DateTime? FinishedAt;

        [DataMember(Name = "artifacts_file")]
        public ArtifactsFile ArtifactsFile;

        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "status")]
        public BuildStatus? Status;

        [DataMember(Name = "user")]
        public User User;
    }

    public enum BuildStatus {
        undefined,
        pending,
        running,
        failed,
        success,
        canceled
    }
}
