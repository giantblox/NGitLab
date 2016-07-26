using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab.Impl {
    public class MergeRequestCommitsClient : IMergeRequestCommitsClient {
        readonly API _api;
        readonly string _commitsPath;

        public MergeRequestCommitsClient(API api, string projectPath, int mergeRequestId) {
            _api = api;
            _commitsPath = projectPath + "/merge_request/" + mergeRequestId + Commit.Url;
        }
        public IEnumerable<Commit> All => _api.Get().GetAll<Commit>(_commitsPath);
    }
}