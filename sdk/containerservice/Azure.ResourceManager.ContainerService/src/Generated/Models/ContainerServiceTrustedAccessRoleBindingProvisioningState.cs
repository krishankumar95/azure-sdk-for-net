// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> The current provisioning state of trusted access role binding. </summary>
    public readonly partial struct ContainerServiceTrustedAccessRoleBindingProvisioningState : IEquatable<ContainerServiceTrustedAccessRoleBindingProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRoleBindingProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContainerServiceTrustedAccessRoleBindingProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CanceledValue = "Canceled";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string UpdatingValue = "Updating";

        /// <summary> Canceled. </summary>
        public static ContainerServiceTrustedAccessRoleBindingProvisioningState Canceled { get; } = new ContainerServiceTrustedAccessRoleBindingProvisioningState(CanceledValue);
        /// <summary> Deleting. </summary>
        public static ContainerServiceTrustedAccessRoleBindingProvisioningState Deleting { get; } = new ContainerServiceTrustedAccessRoleBindingProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static ContainerServiceTrustedAccessRoleBindingProvisioningState Failed { get; } = new ContainerServiceTrustedAccessRoleBindingProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static ContainerServiceTrustedAccessRoleBindingProvisioningState Succeeded { get; } = new ContainerServiceTrustedAccessRoleBindingProvisioningState(SucceededValue);
        /// <summary> Updating. </summary>
        public static ContainerServiceTrustedAccessRoleBindingProvisioningState Updating { get; } = new ContainerServiceTrustedAccessRoleBindingProvisioningState(UpdatingValue);
        /// <summary> Determines if two <see cref="ContainerServiceTrustedAccessRoleBindingProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ContainerServiceTrustedAccessRoleBindingProvisioningState left, ContainerServiceTrustedAccessRoleBindingProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ContainerServiceTrustedAccessRoleBindingProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ContainerServiceTrustedAccessRoleBindingProvisioningState left, ContainerServiceTrustedAccessRoleBindingProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ContainerServiceTrustedAccessRoleBindingProvisioningState"/>. </summary>
        public static implicit operator ContainerServiceTrustedAccessRoleBindingProvisioningState(string value) => new ContainerServiceTrustedAccessRoleBindingProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContainerServiceTrustedAccessRoleBindingProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ContainerServiceTrustedAccessRoleBindingProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
