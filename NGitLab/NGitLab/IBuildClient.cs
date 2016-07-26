using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab {
    public interface IBuildClient {
        IEnumerable<Build> GetBuildsForCommit(Sha1 sha);
        IEnumerable<Build> GetBuilds();
    }
}
