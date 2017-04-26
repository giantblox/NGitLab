using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class UserUpsert {
        [DataMember(Name = "bio")]
        public string Bio;

        [DataMember(Name = "can_create_group")]
        public bool CanCreateGroup;

        [Required]
        [DataMember(Name = "email")]
        public string Email;

        [DataMember(Name = "admin")]
        public bool IsAdmin;

        [DataMember(Name = "linkedin")]
        public string Linkedin;

        [Required]
        [DataMember(Name = "name")]
        public string Name;

        [Required]
        [DataMember(Name = "password")]
        public string Password;

        [DataMember(Name = "projects_limit")]
        public int ProjectsLimit;

        [DataMember(Name = "provider")]
        public string Provider;

        [DataMember(Name = "extern_uid")]
        public string ExternUid;

        [DataMember(Name = "skype")]
        public string Skype;

        [DataMember(Name = "twitter")]
        public string Twitter;

        [Required]
        [DataMember(Name = "username")]
        public string Username;

        [DataMember(Name = "website_url")]
        public string WebsiteURL;
    }
}