// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Defines the different types of VM guest operating systems. </summary>
    public readonly partial struct VMwareOSType : IEquatable<VMwareOSType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VMwareOSType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VMwareOSType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsValue = "Windows";
        private const string LinuxValue = "Linux";
        private const string OtherValue = "Other";

        /// <summary> Windows. </summary>
        public static VMwareOSType Windows { get; } = new VMwareOSType(WindowsValue);
        /// <summary> Linux. </summary>
        public static VMwareOSType Linux { get; } = new VMwareOSType(LinuxValue);
        /// <summary> Other. </summary>
        public static VMwareOSType Other { get; } = new VMwareOSType(OtherValue);
        /// <summary> Determines if two <see cref="VMwareOSType"/> values are the same. </summary>
        public static bool operator ==(VMwareOSType left, VMwareOSType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VMwareOSType"/> values are not the same. </summary>
        public static bool operator !=(VMwareOSType left, VMwareOSType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="VMwareOSType"/>. </summary>
        public static implicit operator VMwareOSType(string value) => new VMwareOSType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VMwareOSType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VMwareOSType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
