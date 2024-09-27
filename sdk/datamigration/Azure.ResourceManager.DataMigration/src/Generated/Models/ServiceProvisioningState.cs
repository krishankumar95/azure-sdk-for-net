// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The resource's provisioning state. </summary>
    public readonly partial struct ServiceProvisioningState : IEquatable<ServiceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string DeletingValue = "Deleting";
        private const string DeployingValue = "Deploying";
        private const string StoppedValue = "Stopped";
        private const string StoppingValue = "Stopping";
        private const string StartingValue = "Starting";
        private const string FailedToStartValue = "FailedToStart";
        private const string FailedToStopValue = "FailedToStop";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Accepted. </summary>
        public static ServiceProvisioningState Accepted { get; } = new ServiceProvisioningState(AcceptedValue);
        /// <summary> Deleting. </summary>
        public static ServiceProvisioningState Deleting { get; } = new ServiceProvisioningState(DeletingValue);
        /// <summary> Deploying. </summary>
        public static ServiceProvisioningState Deploying { get; } = new ServiceProvisioningState(DeployingValue);
        /// <summary> Stopped. </summary>
        public static ServiceProvisioningState Stopped { get; } = new ServiceProvisioningState(StoppedValue);
        /// <summary> Stopping. </summary>
        public static ServiceProvisioningState Stopping { get; } = new ServiceProvisioningState(StoppingValue);
        /// <summary> Starting. </summary>
        public static ServiceProvisioningState Starting { get; } = new ServiceProvisioningState(StartingValue);
        /// <summary> FailedToStart. </summary>
        public static ServiceProvisioningState FailedToStart { get; } = new ServiceProvisioningState(FailedToStartValue);
        /// <summary> FailedToStop. </summary>
        public static ServiceProvisioningState FailedToStop { get; } = new ServiceProvisioningState(FailedToStopValue);
        /// <summary> Succeeded. </summary>
        public static ServiceProvisioningState Succeeded { get; } = new ServiceProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ServiceProvisioningState Failed { get; } = new ServiceProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="ServiceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ServiceProvisioningState left, ServiceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ServiceProvisioningState left, ServiceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ServiceProvisioningState"/>. </summary>
        public static implicit operator ServiceProvisioningState(string value) => new ServiceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
