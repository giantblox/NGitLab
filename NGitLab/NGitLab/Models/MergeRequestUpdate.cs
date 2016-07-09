﻿using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class MergeRequestUpdate {
        [DataMember(Name = "assignee_id")]
        public int? AssigneeId;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "state_event")]
        public string NewState;

        [DataMember(Name = "source_branch")]
        public string SourceBranch;

        [DataMember(Name = "target_branch")]
        public string TargetBranch;

        [DataMember(Name = "title")]
        public string Title;
    }

    // ReSharper disable InconsistentNaming
    public enum MergeRequestStateEvent {
        close,
        reopen,
        merge
    }
}