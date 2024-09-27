// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The provisioning state of the virtual machine. </summary>
    public readonly partial struct VirtualMachineProvisioningState : IEquatable<VirtualMachineProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualMachineProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualMachineProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string ProvisioningValue = "Provisioning";
        private const string AcceptedValue = "Accepted";

        /// <summary> Succeeded. </summary>
        public static VirtualMachineProvisioningState Succeeded { get; } = new VirtualMachineProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static VirtualMachineProvisioningState Failed { get; } = new VirtualMachineProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static VirtualMachineProvisioningState Canceled { get; } = new VirtualMachineProvisioningState(CanceledValue);
        /// <summary> Provisioning. </summary>
        public static VirtualMachineProvisioningState Provisioning { get; } = new VirtualMachineProvisioningState(ProvisioningValue);
        /// <summary> Accepted. </summary>
        public static VirtualMachineProvisioningState Accepted { get; } = new VirtualMachineProvisioningState(AcceptedValue);
        /// <summary> Determines if two <see cref="VirtualMachineProvisioningState"/> values are the same. </summary>
        public static bool operator ==(VirtualMachineProvisioningState left, VirtualMachineProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualMachineProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(VirtualMachineProvisioningState left, VirtualMachineProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VirtualMachineProvisioningState"/>. </summary>
        public static implicit operator VirtualMachineProvisioningState(string value) => new VirtualMachineProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualMachineProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualMachineProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
