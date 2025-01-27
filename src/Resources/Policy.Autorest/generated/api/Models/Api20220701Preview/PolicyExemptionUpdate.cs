// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Extensions;

    /// <summary>The policy exemption for Patch request.</summary>
    public partial class PolicyExemptionUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal
    {

        /// <summary>The option whether validate the exemption is at or under the assignment scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.AssignmentScopeValidation? AssignmentScopeValidation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdatePropertiesInternal)Property).AssignmentScopeValidation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdatePropertiesInternal)Property).AssignmentScopeValidation = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.AssignmentScopeValidation)""); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.PolicyExemptionUpdateProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateProperties _property;

        /// <summary>The policy exemption properties for Patch request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.PolicyExemptionUpdateProperties()); set => this._property = value; }

        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector[] ResourceSelector { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdatePropertiesInternal)Property).ResourceSelector; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdatePropertiesInternal)Property).ResourceSelector = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="PolicyExemptionUpdate" /> instance.</summary>
        public PolicyExemptionUpdate()
        {

        }
    }
    /// The policy exemption for Patch request.
    public partial interface IPolicyExemptionUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IJsonSerializable
    {
        /// <summary>The option whether validate the exemption is at or under the assignment scope.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The option whether validate the exemption is at or under the assignment scope.",
        SerializedName = @"assignmentScopeValidation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.AssignmentScopeValidation) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.AssignmentScopeValidation? AssignmentScopeValidation { get; set; }
        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource selector list to filter policies by resource properties.",
        SerializedName = @"resourceSelectors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector[] ResourceSelector { get; set; }

    }
    /// The policy exemption for Patch request.
    internal partial interface IPolicyExemptionUpdateInternal

    {
        /// <summary>The option whether validate the exemption is at or under the assignment scope.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.AssignmentScopeValidation? AssignmentScopeValidation { get; set; }
        /// <summary>The policy exemption properties for Patch request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220701Preview.IPolicyExemptionUpdateProperties Property { get; set; }
        /// <summary>The resource selector list to filter policies by resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ApiV1.IResourceSelector[] ResourceSelector { get; set; }

    }
}