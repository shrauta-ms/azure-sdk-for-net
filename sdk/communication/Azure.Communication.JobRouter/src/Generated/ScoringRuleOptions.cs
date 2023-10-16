// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary>
    /// Encapsulates all options that can be passed as parameters for scoring rule with
    /// BestWorkerMode
    /// </summary>
    public partial class ScoringRuleOptions
    {
        /// <summary> Initializes a new instance of ScoringRuleOptions. </summary>
        internal ScoringRuleOptions()
        {
            ScoringParameters = new ChangeTrackingList<ScoringRuleParameterSelector>();
        }

        /// <summary> Initializes a new instance of ScoringRuleOptions. </summary>
        /// <param name="batchSize">
        /// (Optional) Set batch size when AllowScoringBatchOfWorkers is set to true.
        /// Defaults to 20 if not configured.
        /// </param>
        /// <param name="scoringParameters">
        /// (Optional) List of extra parameters from the job that will be sent as part of
        /// the payload to scoring rule.
        /// If not set, the job's labels (sent in the payload
        /// as `job`) and the job's worker selectors (sent in the payload as
        /// `selectors`)
        /// are added to the payload of the scoring rule by default.
        /// Note:
        /// Worker labels are always sent with scoring payload.
        /// </param>
        /// <param name="allowScoringBatchOfWorkers">
        /// (Optional)
        /// If set to true, will score workers in batches, and the parameter
        /// name of the worker labels will be sent as `workers`.
        /// By default, set to false
        /// and the parameter name for the worker labels will be sent as `worker`.
        /// Note: If
        /// enabled, use BatchSize to set batch size.
        /// </param>
        /// <param name="descendingOrder">
        /// (Optional)
        /// If false, will sort scores by ascending order. By default, set to
        /// true.
        /// </param>
        internal ScoringRuleOptions(int? batchSize, IList<ScoringRuleParameterSelector> scoringParameters, bool? allowScoringBatchOfWorkers, bool? descendingOrder)
        {
            BatchSize = batchSize;
            ScoringParameters = scoringParameters;
            AllowScoringBatchOfWorkers = allowScoringBatchOfWorkers;
            DescendingOrder = descendingOrder;
        }

        /// <summary>
        /// (Optional) Set batch size when AllowScoringBatchOfWorkers is set to true.
        /// Defaults to 20 if not configured.
        /// </summary>
        public int? BatchSize { get; }
        /// <summary>
        /// (Optional)
        /// If set to true, will score workers in batches, and the parameter
        /// name of the worker labels will be sent as `workers`.
        /// By default, set to false
        /// and the parameter name for the worker labels will be sent as `worker`.
        /// Note: If
        /// enabled, use BatchSize to set batch size.
        /// </summary>
        public bool? AllowScoringBatchOfWorkers { get; }
        /// <summary>
        /// (Optional)
        /// If false, will sort scores by ascending order. By default, set to
        /// true.
        /// </summary>
        public bool? DescendingOrder { get; }
    }
}
