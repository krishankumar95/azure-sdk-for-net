// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct SslProtocolOperator : IEquatable<SslProtocolOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SslProtocolOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SslProtocolOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualValue = "Equal";

        /// <summary> Equal. </summary>
        public static SslProtocolOperator Equal { get; } = new SslProtocolOperator(EqualValue);
        /// <summary> Determines if two <see cref="SslProtocolOperator"/> values are the same. </summary>
        public static bool operator ==(SslProtocolOperator left, SslProtocolOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SslProtocolOperator"/> values are not the same. </summary>
        public static bool operator !=(SslProtocolOperator left, SslProtocolOperator right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SslProtocolOperator"/>. </summary>
        public static implicit operator SslProtocolOperator(string value) => new SslProtocolOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SslProtocolOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SslProtocolOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
