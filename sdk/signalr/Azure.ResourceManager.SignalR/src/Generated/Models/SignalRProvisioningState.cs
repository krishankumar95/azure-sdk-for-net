// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Provisioning state of the resource. </summary>
    public readonly partial struct SignalRProvisioningState : IEquatable<SignalRProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SignalRProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SignalRProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string RunningValue = "Running";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string MovingValue = "Moving";

        /// <summary> Unknown. </summary>
        public static SignalRProvisioningState Unknown { get; } = new SignalRProvisioningState(UnknownValue);
        /// <summary> Succeeded. </summary>
        public static SignalRProvisioningState Succeeded { get; } = new SignalRProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static SignalRProvisioningState Failed { get; } = new SignalRProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static SignalRProvisioningState Canceled { get; } = new SignalRProvisioningState(CanceledValue);
        /// <summary> Running. </summary>
        public static SignalRProvisioningState Running { get; } = new SignalRProvisioningState(RunningValue);
        /// <summary> Creating. </summary>
        public static SignalRProvisioningState Creating { get; } = new SignalRProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static SignalRProvisioningState Updating { get; } = new SignalRProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static SignalRProvisioningState Deleting { get; } = new SignalRProvisioningState(DeletingValue);
        /// <summary> Moving. </summary>
        public static SignalRProvisioningState Moving { get; } = new SignalRProvisioningState(MovingValue);
        /// <summary> Determines if two <see cref="SignalRProvisioningState"/> values are the same. </summary>
        public static bool operator ==(SignalRProvisioningState left, SignalRProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SignalRProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(SignalRProvisioningState left, SignalRProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SignalRProvisioningState"/>. </summary>
        public static implicit operator SignalRProvisioningState(string value) => new SignalRProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SignalRProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SignalRProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
