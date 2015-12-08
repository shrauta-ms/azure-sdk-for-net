// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class USql : JobProperties
    {
        /// <summary>
        /// Initializes a new instance of the USql class.
        /// </summary>
        public USql() { }

        /// <summary>
        /// Initializes a new instance of the USql class.
        /// </summary>
        public USql(string script, string runtimeVersion = default(string), IList<JobResource> resources = default(IList<JobResource>), JobStatistics statistics = default(JobStatistics), JobDataPath debugData = default(JobDataPath), string algebraFilePath = default(string), string totalCompilationTime = default(string), string totalPauseTime = default(string), string totalQueuedTime = default(string), string totalRunningTime = default(string), string rootProcessNodeId = default(string), string yarnApplicationId = default(string), long? yarnApplicationTimeStamp = default(long?), string compileMode = default(string))
            : base(script, runtimeVersion)
        {
            Resources = resources;
            Statistics = statistics;
            DebugData = debugData;
            AlgebraFilePath = algebraFilePath;
            TotalCompilationTime = totalCompilationTime;
            TotalPauseTime = totalPauseTime;
            TotalQueuedTime = totalQueuedTime;
            TotalRunningTime = totalRunningTime;
            RootProcessNodeId = rootProcessNodeId;
            YarnApplicationId = yarnApplicationId;
            YarnApplicationTimeStamp = yarnApplicationTimeStamp;
            CompileMode = compileMode;
        }

        /// <summary>
        /// Gets or sets the list of resources that are required by the job
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<JobResource> Resources { get; set; }

        /// <summary>
        /// Gets or sets the job specific statistics.
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public JobStatistics Statistics { get; set; }

        /// <summary>
        /// Gets or sets the job specific debug data locations.
        /// </summary>
        [JsonProperty(PropertyName = "debugData")]
        public JobDataPath DebugData { get; set; }

        /// <summary>
        /// Gets or sets the U-SQL algebra file path after the job has
        /// completed
        /// </summary>
        [JsonProperty(PropertyName = "algebraFilePath")]
        public string AlgebraFilePath { get; set; }

        /// <summary>
        /// Gets or sets the total time this job spent compiling. This value
        /// should not be set by the user and will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "totalCompilationTime")]
        public string TotalCompilationTime { get; set; }

        /// <summary>
        /// Gets or sets the total time this job spent paused. This value
        /// should not be set by the user and will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "totalPauseTime")]
        public string TotalPauseTime { get; set; }

        /// <summary>
        /// Gets or sets the total time this job spent queued. This value
        /// should not be set by the user and will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "totalQueuedTime")]
        public string TotalQueuedTime { get; set; }

        /// <summary>
        /// Gets or sets the total time this job spent executing. This value
        /// should not be set by the user and will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "totalRunningTime")]
        public string TotalRunningTime { get; set; }

        /// <summary>
        /// Gets or sets the ID used to identify the job manager coordinating
        /// job execution. This value should not be set by the user and will
        /// be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "rootProcessNodeId")]
        public string RootProcessNodeId { get; set; }

        /// <summary>
        /// Gets or sets the ID used to identify the yarn application
        /// executing the job. This value should not be set by the user and
        /// will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "yarnApplicationId")]
        public string YarnApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the timestamp (in ticks) for the yarn application
        /// executing the job. This value should not be set by the user and
        /// will be ignored if it is.
        /// </summary>
        [JsonProperty(PropertyName = "yarnApplicationTimeStamp")]
        public long? YarnApplicationTimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the compile mode for the job. Possible values for
        /// this property include: 'Semantic', 'Full', 'SingleBox'.
        /// </summary>
        [JsonProperty(PropertyName = "compileMode")]
        public string CompileMode { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
