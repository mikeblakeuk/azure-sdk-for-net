// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Specifies details of a Job Manager task.
    /// </summary>
    public partial class JobManagerTask
    {
        /// <summary>
        /// Initializes a new instance of the JobManagerTask class.
        /// </summary>
        public JobManagerTask() { }

        /// <summary>
        /// Initializes a new instance of the JobManagerTask class.
        /// </summary>
        public JobManagerTask(string id = default(string), string displayName = default(string), string commandLine = default(string), IList<ResourceFile> resourceFiles = default(IList<ResourceFile>), IList<EnvironmentSetting> environmentSettings = default(IList<EnvironmentSetting>), TaskConstraints constraints = default(TaskConstraints), bool? killJobOnCompletion = default(bool?), bool? runElevated = default(bool?), bool? runExclusive = default(bool?))
        {
            Id = id;
            DisplayName = displayName;
            CommandLine = commandLine;
            ResourceFiles = resourceFiles;
            EnvironmentSettings = environmentSettings;
            Constraints = constraints;
            KillJobOnCompletion = killJobOnCompletion;
            RunElevated = runElevated;
            RunExclusive = runExclusive;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the Job Manager
        /// task. A GUID is recommended.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name of the Job Manager task.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the command line of the Job Manager task.
        /// </summary>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets a list of files that Batch will download to the
        /// compute node before running the command line.
        /// </summary>
        [JsonProperty(PropertyName = "resourceFiles")]
        public IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the Job
        /// Manager task.
        /// </summary>
        [JsonProperty(PropertyName = "environmentSettings")]
        public IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets constraints that apply to the Job Manager task.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public TaskConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets whether completion of the Job Manager task signifies
        /// completion of the entire job.
        /// </summary>
        [JsonProperty(PropertyName = "killJobOnCompletion")]
        public bool? KillJobOnCompletion { get; set; }

        /// <summary>
        /// Gets or sets whether to run the Job Manager task in elevated mode.
        /// The default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "runElevated")]
        public bool? RunElevated { get; set; }

        /// <summary>
        /// Gets or sets whether the Job Manager task requires exclusive use
        /// of the compute node where it runs.
        /// </summary>
        [JsonProperty(PropertyName = "runExclusive")]
        public bool? RunExclusive { get; set; }

    }
}