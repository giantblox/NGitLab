﻿using System;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class Assignee {
        [DataMember(Name = "created_at")]
        public DateTime CreatedAt;

        [DataMember(Name = "email")]
        public string Email;

        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "state")]
        public string State;

        [DataMember(Name = "username")]
        public string Username;
    }
}