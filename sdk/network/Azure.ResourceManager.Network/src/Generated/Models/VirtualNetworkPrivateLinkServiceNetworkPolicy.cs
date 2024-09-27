// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Enable or Disable apply network policies on private link service in the subnet. </summary>
    public readonly partial struct VirtualNetworkPrivateLinkServiceNetworkPolicy : IEquatable<VirtualNetworkPrivateLinkServiceNetworkPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkPrivateLinkServiceNetworkPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VirtualNetworkPrivateLinkServiceNetworkPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static VirtualNetworkPrivateLinkServiceNetworkPolicy Enabled { get; } = new VirtualNetworkPrivateLinkServiceNetworkPolicy(EnabledValue);
        /// <summary> Disabled. </summary>
        public static VirtualNetworkPrivateLinkServiceNetworkPolicy Disabled { get; } = new VirtualNetworkPrivateLinkServiceNetworkPolicy(DisabledValue);
        /// <summary> Determines if two <see cref="VirtualNetworkPrivateLinkServiceNetworkPolicy"/> values are the same. </summary>
        public static bool operator ==(VirtualNetworkPrivateLinkServiceNetworkPolicy left, VirtualNetworkPrivateLinkServiceNetworkPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VirtualNetworkPrivateLinkServiceNetworkPolicy"/> values are not the same. </summary>
        public static bool operator !=(VirtualNetworkPrivateLinkServiceNetworkPolicy left, VirtualNetworkPrivateLinkServiceNetworkPolicy right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VirtualNetworkPrivateLinkServiceNetworkPolicy"/>. </summary>
        public static implicit operator VirtualNetworkPrivateLinkServiceNetworkPolicy(string value) => new VirtualNetworkPrivateLinkServiceNetworkPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VirtualNetworkPrivateLinkServiceNetworkPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VirtualNetworkPrivateLinkServiceNetworkPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
