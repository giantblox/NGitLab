using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab.Impl {
    public class BuildClient : IBuildClient {
        readonly API _api;
        readonly string _buildsFromCommitPath;
        readonly string _builds;
        public BuildClient(API api, string projectPath, string repoPath) {
            _api = api;
            _builds = projectPath + Build.Url;
            _buildsFromCommitPath = repoPath + Commit.Url;
        }
        public IEnumerable<Build> GetBuildsForCommit(Sha1 sha) {
            return _api.Get().GetAll<Build>(_buildsFromCommitPath + "/" + sha.ToString().ToLowerInvariant() + Build.Url);
        }
        public IEnumerable<Build> GetBuilds() {
            return _api.Get().GetAll<Build>(_builds);
        }
    }
}
