// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Extensions;

    public partial class UserAssignedIdentitiesValue :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.IUserAssignedIdentitiesValue,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.IUserAssignedIdentitiesValueInternal
    {

        /// <summary>Backing field for <see cref="ClientId" /> property.</summary>
        private string _clientId;

        /// <summary>The client id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string ClientId { get => this._clientId; }

        /// <summary>Internal Acessors for ClientId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.IUserAssignedIdentitiesValueInternal.ClientId { get => this._clientId; set { {_clientId = value;} } }

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.Api20220601.IUserAssignedIdentitiesValueInternal.PrincipalId { get => this._principalId; set { {_principalId = value;} } }

        /// <summary>Backing field for <see cref="PrincipalId" /> property.</summary>
        private string _principalId;

        /// <summary>The principal id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        public string PrincipalId { get => this._principalId; }

        /// <summary>Creates an new <see cref="UserAssignedIdentitiesValue" /> instance.</summary>
        public UserAssignedIdentitiesValue()
        {

        }
    }
    public partial interface IUserAssignedIdentitiesValue :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IJsonSerializable
    {
        /// <summary>The client id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The client id of user assigned identity.",
        SerializedName = @"clientId",
        PossibleTypes = new [] { typeof(string) })]
        string ClientId { get;  }
        /// <summary>The principal id of user assigned identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The principal id of user assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string PrincipalId { get;  }

    }
    internal partial interface IUserAssignedIdentitiesValueInternal

    {
        /// <summary>The client id of user assigned identity.</summary>
        string ClientId { get; set; }
        /// <summary>The principal id of user assigned identity.</summary>
        string PrincipalId { get; set; }

    }
}