// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The source type of the machine group. </summary>
    public readonly partial struct AdaptiveApplicationControlGroupSourceSystem : IEquatable<AdaptiveApplicationControlGroupSourceSystem>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AdaptiveApplicationControlGroupSourceSystem"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AdaptiveApplicationControlGroupSourceSystem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureAppLockerValue = "Azure_AppLocker";
        private const string AzureAuditDValue = "Azure_AuditD";
        private const string NonAzureAppLockerValue = "NonAzure_AppLocker";
        private const string NonAzureAuditDValue = "NonAzure_AuditD";
        private const string NoneValue = "None";

        /// <summary> Azure_AppLocker. </summary>
        public static AdaptiveApplicationControlGroupSourceSystem AzureAppLocker { get; } = new AdaptiveApplicationControlGroupSourceSystem(AzureAppLockerValue);
        /// <summary> Azure_AuditD. </summary>
        public static AdaptiveApplicationControlGroupSourceSystem AzureAuditD { get; } = new AdaptiveApplicationControlGroupSourceSystem(AzureAuditDValue);
        /// <summary> NonAzure_AppLocker. </summary>
        public static AdaptiveApplicationControlGroupSourceSystem NonAzureAppLocker { get; } = new AdaptiveApplicationControlGroupSourceSystem(NonAzureAppLockerValue);
        /// <summary> NonAzure_AuditD. </summary>
        public static AdaptiveApplicationControlGroupSourceSystem NonAzureAuditD { get; } = new AdaptiveApplicationControlGroupSourceSystem(NonAzureAuditDValue);
        /// <summary> None. </summary>
        public static AdaptiveApplicationControlGroupSourceSystem None { get; } = new AdaptiveApplicationControlGroupSourceSystem(NoneValue);
        /// <summary> Determines if two <see cref="AdaptiveApplicationControlGroupSourceSystem"/> values are the same. </summary>
        public static bool operator ==(AdaptiveApplicationControlGroupSourceSystem left, AdaptiveApplicationControlGroupSourceSystem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AdaptiveApplicationControlGroupSourceSystem"/> values are not the same. </summary>
        public static bool operator !=(AdaptiveApplicationControlGroupSourceSystem left, AdaptiveApplicationControlGroupSourceSystem right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AdaptiveApplicationControlGroupSourceSystem"/>. </summary>
        public static implicit operator AdaptiveApplicationControlGroupSourceSystem(string value) => new AdaptiveApplicationControlGroupSourceSystem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AdaptiveApplicationControlGroupSourceSystem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AdaptiveApplicationControlGroupSourceSystem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
