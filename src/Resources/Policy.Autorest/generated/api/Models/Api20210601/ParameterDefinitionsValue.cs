// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Extensions;

    /// <summary>The definition of a parameter that can be provided to the policy.</summary>
    public partial class ParameterDefinitionsValue :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValue,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueInternal
    {

        /// <summary>Backing field for <see cref="AllowedValue" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitionsValueAllowedValuesItem[] _allowedValue;

        /// <summary>The allowed values for the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitionsValueAllowedValuesItem[] AllowedValue { get => this._allowedValue; set => this._allowedValue = value; }

        /// <summary>Backing field for <see cref="DefaultValue" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueDefaultValue _defaultValue;

        /// <summary>The default value for the parameter if no value is provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueDefaultValue DefaultValue { get => (this._defaultValue = this._defaultValue ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.ParameterDefinitionsValueDefaultValue()); set => this._defaultValue = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata _metadata;

        /// <summary>General metadata for the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.ParameterDefinitionsValueMetadata()); set => this._metadata = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType? _type;

        /// <summary>The data type of the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="ParameterDefinitionsValue" /> instance.</summary>
        public ParameterDefinitionsValue()
        {

        }
    }
    /// The definition of a parameter that can be provided to the policy.
    public partial interface IParameterDefinitionsValue :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IJsonSerializable
    {
        /// <summary>The allowed values for the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The allowed values for the parameter.",
        SerializedName = @"allowedValues",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitionsValueAllowedValuesItem) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitionsValueAllowedValuesItem[] AllowedValue { get; set; }
        /// <summary>The default value for the parameter if no value is provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The default value for the parameter if no value is provided.",
        SerializedName = @"defaultValue",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueDefaultValue) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueDefaultValue DefaultValue { get; set; }
        /// <summary>General metadata for the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"General metadata for the parameter.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata Metadata { get; set; }
        /// <summary>The data type of the parameter.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The data type of the parameter.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType? Type { get; set; }

    }
    /// The definition of a parameter that can be provided to the policy.
    internal partial interface IParameterDefinitionsValueInternal

    {
        /// <summary>The allowed values for the parameter.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitionsValueAllowedValuesItem[] AllowedValue { get; set; }
        /// <summary>The default value for the parameter if no value is provided.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueDefaultValue DefaultValue { get; set; }
        /// <summary>General metadata for the parameter.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20210601.IParameterDefinitionsValueMetadata Metadata { get; set; }
        /// <summary>The data type of the parameter.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Support.ParameterType? Type { get; set; }

    }
}