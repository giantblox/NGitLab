using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models {
    [DataContract]
    public class ProjectHookClientSide {
        [DataType("object_kind")]
        public ProjectHookType HookType { get; set; }
    }

    public enum ProjectHookType {
        push,
        tag_push,
        issue,
        note,
        merge_request
    }
}
