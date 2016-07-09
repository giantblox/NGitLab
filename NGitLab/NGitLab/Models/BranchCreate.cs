﻿using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class BranchCreate {
        [DataMember(Name = "branch_name")]
        public string Name;

        [DataMember(Name = "ref")]
        public string Ref;
    }
}