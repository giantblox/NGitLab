using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab {
    public interface IMergeRequestCommitsClient {
        IEnumerable<Commit> All { get; }
    }
}
