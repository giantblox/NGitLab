using NGitLab.Models;

namespace NGitLab.Impl {
    public class MergeRequestChangesClient : IMergeRequestChangesClient {
        readonly API _api;
        readonly string _changesPath;

        public MergeRequestChangesClient(API api, string projectPath, int mergeRequestId) {
            _api = api;
            _changesPath = projectPath + "/merge_request/" + mergeRequestId + "/changes";
        }

        public MergeRequestChanges Changes {
            get { return _api.Get().To<MergeRequestChanges>(_changesPath); }
        }
    }
}