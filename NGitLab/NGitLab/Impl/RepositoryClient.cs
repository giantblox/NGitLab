﻿using System;
using System.Collections.Generic;
using System.IO;
using NGitLab.Models;

namespace NGitLab.Impl {
    public class RepositoryClient : IRepositoryClient {
        readonly API _api;
        readonly string _projectPath;
        readonly string _repoPath;

        public RepositoryClient(API api, int projectId) {
            _api = api;

            _projectPath = Project.Url + "/" + projectId;
            _repoPath = _projectPath + "/repository";
        }

        public IEnumerable<Tag> Tags => _api.Get().GetAll<Tag>(_repoPath + "/tags");

        public IEnumerable<TreeOrBlob> Tree => _api.Get().GetAll<TreeOrBlob>(_repoPath + "/tree");

        public void GetRawBlob(string sha, Action<Stream> parser) {
            _api.Get().Stream(_repoPath + "/raw_blobs/" + sha, parser);
        }

        public IEnumerable<Commit> Commits => _api.Get().GetAll<Commit>(_repoPath + "/commits");

        public SingleCommit GetCommit(Sha1 sha) {
            return _api.Get().To<SingleCommit>(_repoPath + "/commits/" + sha);
        }
        public IEnumerable<Diff> GetCommitDiff(Sha1 sha) {
            return _api.Get().GetAll<Diff>(_repoPath + "/commits/" + sha + "/diff");
        }
        public IFilesClient Files => new FileClient(_api, _repoPath);
        public IBranchClient Branches => new BranchClient(_api, _repoPath);

        public IProjectHooksClient ProjectHooks => new ProjectHooksClient(_api, _projectPath);
        public IBuildClient Builds => new BuildClient(_api, _projectPath, _repoPath);
    }
}