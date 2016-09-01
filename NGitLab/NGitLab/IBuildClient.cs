using System;
using System.Collections.Generic;
using System.IO;
using NGitLab.Models;

namespace NGitLab {
    public interface IBuildClient {
        IEnumerable<Build> GetBuildsForCommit(Sha1 sha);
        IEnumerable<Build> GetBuilds();
        void GetArtifactFile(Build build, Action<Stream> parser);
        void GetTraceFile(Build build, Action<Stream> parser);
        Build Retry(Build build);
        Build Cancel(Build build);
    }
}
