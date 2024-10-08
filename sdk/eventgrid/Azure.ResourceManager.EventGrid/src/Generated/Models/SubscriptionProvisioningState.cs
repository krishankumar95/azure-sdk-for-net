// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the event subscription. </summary>
    public readonly partial struct SubscriptionProvisioningState : IEquatable<SubscriptionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SubscriptionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SubscriptionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";
        private const string AwaitingManualActionValue = "AwaitingManualAction";
        private const string DeletedValue = "Deleted";
        private const string DeleteFailedValue = "DeleteFailed";
        private const string CreateFailedValue = "CreateFailed";
        private const string UpdatedFailedValue = "UpdatedFailed";

        /// <summary> Creating. </summary>
        public static SubscriptionProvisioningState Creating { get; } = new SubscriptionProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static SubscriptionProvisioningState Updating { get; } = new SubscriptionProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static SubscriptionProvisioningState Deleting { get; } = new SubscriptionProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static SubscriptionProvisioningState Succeeded { get; } = new SubscriptionProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static SubscriptionProvisioningState Canceled { get; } = new SubscriptionProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static SubscriptionProvisioningState Failed { get; } = new SubscriptionProvisioningState(FailedValue);
        /// <summary> AwaitingManualAction. </summary>
        public static SubscriptionProvisioningState AwaitingManualAction { get; } = new SubscriptionProvisioningState(AwaitingManualActionValue);
        /// <summary> Deleted. </summary>
        public static SubscriptionProvisioningState Deleted { get; } = new SubscriptionProvisioningState(DeletedValue);
        /// <summary> DeleteFailed. </summary>
        public static SubscriptionProvisioningState DeleteFailed { get; } = new SubscriptionProvisioningState(DeleteFailedValue);
        /// <summary> CreateFailed. </summary>
        public static SubscriptionProvisioningState CreateFailed { get; } = new SubscriptionProvisioningState(CreateFailedValue);
        /// <summary> UpdatedFailed. </summary>
        public static SubscriptionProvisioningState UpdatedFailed { get; } = new SubscriptionProvisioningState(UpdatedFailedValue);
        /// <summary> Determines if two <see cref="SubscriptionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(SubscriptionProvisioningState left, SubscriptionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SubscriptionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(SubscriptionProvisioningState left, SubscriptionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SubscriptionProvisioningState"/>. </summary>
        public static implicit operator SubscriptionProvisioningState(string value) => new SubscriptionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SubscriptionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SubscriptionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
