using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab {
    public interface IMergeRequestClient {
        IEnumerable<MergeRequest> All { get; }
        MergeRequest this[int id] { get; }
        IEnumerable<MergeRequest> AllInState(MergeRequestState state);

        MergeRequest Create(MergeRequestCreate mergeRequest);
        MergeRequest Update(int mergeRequestId, MergeRequestUpdate mergeRequest);
        MergeRequest Accept(int mergeRequestId, MergeCommitMessage message);

        IMergeRequestCommentClient Comments(int mergeRequestId);
        IMergeRequestChangesClient Changes(int mergeRequestId);
    }
}