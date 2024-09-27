// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Language extension that can run within KQL query. </summary>
    public readonly partial struct SynapseLanguageExtensionName : IEquatable<SynapseLanguageExtensionName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseLanguageExtensionName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseLanguageExtensionName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PythonValue = "PYTHON";
        private const string RValue = "R";

        /// <summary> PYTHON. </summary>
        public static SynapseLanguageExtensionName Python { get; } = new SynapseLanguageExtensionName(PythonValue);
        /// <summary> R. </summary>
        public static SynapseLanguageExtensionName R { get; } = new SynapseLanguageExtensionName(RValue);
        /// <summary> Determines if two <see cref="SynapseLanguageExtensionName"/> values are the same. </summary>
        public static bool operator ==(SynapseLanguageExtensionName left, SynapseLanguageExtensionName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseLanguageExtensionName"/> values are not the same. </summary>
        public static bool operator !=(SynapseLanguageExtensionName left, SynapseLanguageExtensionName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SynapseLanguageExtensionName"/>. </summary>
        public static implicit operator SynapseLanguageExtensionName(string value) => new SynapseLanguageExtensionName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseLanguageExtensionName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseLanguageExtensionName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
