// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure ML Execute Pipeline activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureMLExecutePipeline")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureMLExecutePipelineActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the AzureMLExecutePipelineActivity
        /// class.
        /// </summary>
        public AzureMLExecutePipelineActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMLExecutePipelineActivity
        /// class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="state">Activity state. This is an optional property
        /// and if not provided, the state will be Active by default. Possible
        /// values include: 'Active', 'Inactive'</param>
        /// <param name="onInactiveMarkAs">Status result of the activity when
        /// the state is set to Inactive. This is an optional property and if
        /// not provided when the activity is inactive, the status will be
        /// Succeeded by default. Possible values include: 'Succeeded',
        /// 'Failed', 'Skipped'</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="mlPipelineId">ID of the published Azure ML pipeline.
        /// Type: string (or Expression with resultType string).</param>
        /// <param name="mlPipelineEndpointId">ID of the published Azure ML
        /// pipeline endpoint. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="version">Version of the published Azure ML pipeline
        /// endpoint. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="experimentName">Run history experiment name of the
        /// pipeline run. This information will be passed in the ExperimentName
        /// property of the published pipeline execution request. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="mlPipelineParameters">Key,Value pairs to be passed to
        /// the published Azure ML pipeline endpoint. Keys must match the names
        /// of pipeline parameters defined in the published pipeline. Values
        /// will be passed in the ParameterAssignments property of the
        /// published pipeline execution request. Type: object with key value
        /// pairs (or Expression with resultType object).</param>
        /// <param name="dataPathAssignments">Dictionary used for changing data
        /// path assignments without retraining. Values will be passed in the
        /// dataPathAssignments property of the published pipeline execution
        /// request. Type: object with key value pairs (or Expression with
        /// resultType object).</param>
        /// <param name="mlParentRunId">The parent Azure ML Service pipeline
        /// run id. This information will be passed in the ParentRunId property
        /// of the published pipeline execution request. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="continueOnStepFailure">Whether to continue execution
        /// of other steps in the PipelineRun if a step fails. This information
        /// will be passed in the continueOnStepFailure property of the
        /// published pipeline execution request. Type: boolean (or Expression
        /// with resultType boolean).</param>
        public AzureMLExecutePipelineActivity(string name, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), string state = default(string), string onInactiveMarkAs = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), object mlPipelineId = default(object), object mlPipelineEndpointId = default(object), object version = default(object), object experimentName = default(object), object mlPipelineParameters = default(object), object dataPathAssignments = default(object), object mlParentRunId = default(object), object continueOnStepFailure = default(object))
            : base(name, additionalProperties, description, state, onInactiveMarkAs, dependsOn, userProperties, linkedServiceName, policy)
        {
            MlPipelineId = mlPipelineId;
            MlPipelineEndpointId = mlPipelineEndpointId;
            Version = version;
            ExperimentName = experimentName;
            MlPipelineParameters = mlPipelineParameters;
            DataPathAssignments = dataPathAssignments;
            MlParentRunId = mlParentRunId;
            ContinueOnStepFailure = continueOnStepFailure;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the published Azure ML pipeline. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlPipelineId")]
        public object MlPipelineId { get; set; }

        /// <summary>
        /// Gets or sets ID of the published Azure ML pipeline endpoint. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlPipelineEndpointId")]
        public object MlPipelineEndpointId { get; set; }

        /// <summary>
        /// Gets or sets version of the published Azure ML pipeline endpoint.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.version")]
        public object Version { get; set; }

        /// <summary>
        /// Gets or sets run history experiment name of the pipeline run. This
        /// information will be passed in the ExperimentName property of the
        /// published pipeline execution request. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.experimentName")]
        public object ExperimentName { get; set; }

        /// <summary>
        /// Gets or sets key,Value pairs to be passed to the published Azure ML
        /// pipeline endpoint. Keys must match the names of pipeline parameters
        /// defined in the published pipeline. Values will be passed in the
        /// ParameterAssignments property of the published pipeline execution
        /// request. Type: object with key value pairs (or Expression with
        /// resultType object).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlPipelineParameters")]
        public object MlPipelineParameters { get; set; }

        /// <summary>
        /// Gets or sets dictionary used for changing data path assignments
        /// without retraining. Values will be passed in the
        /// dataPathAssignments property of the published pipeline execution
        /// request. Type: object with key value pairs (or Expression with
        /// resultType object).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataPathAssignments")]
        public object DataPathAssignments { get; set; }

        /// <summary>
        /// Gets or sets the parent Azure ML Service pipeline run id. This
        /// information will be passed in the ParentRunId property of the
        /// published pipeline execution request. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlParentRunId")]
        public object MlParentRunId { get; set; }

        /// <summary>
        /// Gets or sets whether to continue execution of other steps in the
        /// PipelineRun if a step fails. This information will be passed in the
        /// continueOnStepFailure property of the published pipeline execution
        /// request. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.continueOnStepFailure")]
        public object ContinueOnStepFailure { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
