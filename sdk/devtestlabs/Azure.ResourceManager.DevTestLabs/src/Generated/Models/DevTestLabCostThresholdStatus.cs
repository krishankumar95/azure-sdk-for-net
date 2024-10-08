// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Indicates whether this threshold will be displayed on cost charts. </summary>
    public readonly partial struct DevTestLabCostThresholdStatus : IEquatable<DevTestLabCostThresholdStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevTestLabCostThresholdStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevTestLabCostThresholdStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static DevTestLabCostThresholdStatus Enabled { get; } = new DevTestLabCostThresholdStatus(EnabledValue);
        /// <summary> Disabled. </summary>
        public static DevTestLabCostThresholdStatus Disabled { get; } = new DevTestLabCostThresholdStatus(DisabledValue);
        /// <summary> Determines if two <see cref="DevTestLabCostThresholdStatus"/> values are the same. </summary>
        public static bool operator ==(DevTestLabCostThresholdStatus left, DevTestLabCostThresholdStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevTestLabCostThresholdStatus"/> values are not the same. </summary>
        public static bool operator !=(DevTestLabCostThresholdStatus left, DevTestLabCostThresholdStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DevTestLabCostThresholdStatus"/>. </summary>
        public static implicit operator DevTestLabCostThresholdStatus(string value) => new DevTestLabCostThresholdStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevTestLabCostThresholdStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevTestLabCostThresholdStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
