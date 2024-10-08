// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Current availability stage of the product. Availability stage. </summary>
    public readonly partial struct ProductAvailabilityStage : IEquatable<ProductAvailabilityStage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProductAvailabilityStage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProductAvailabilityStage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string ComingSoonValue = "ComingSoon";
        private const string PreviewValue = "Preview";
        private const string DeprecatedValue = "Deprecated";
        private const string SignUpValue = "Signup";
        private const string UnavailableValue = "Unavailable";

        /// <summary> Product is available. </summary>
        public static ProductAvailabilityStage Available { get; } = new ProductAvailabilityStage(AvailableValue);
        /// <summary> Product is coming soon. </summary>
        public static ProductAvailabilityStage ComingSoon { get; } = new ProductAvailabilityStage(ComingSoonValue);
        /// <summary> Product is in preview. </summary>
        public static ProductAvailabilityStage Preview { get; } = new ProductAvailabilityStage(PreviewValue);
        /// <summary> Product is deprecated. </summary>
        public static ProductAvailabilityStage Deprecated { get; } = new ProductAvailabilityStage(DeprecatedValue);
        /// <summary> Product is available only on signup. </summary>
        public static ProductAvailabilityStage SignUp { get; } = new ProductAvailabilityStage(SignUpValue);
        /// <summary> Product is not available. </summary>
        public static ProductAvailabilityStage Unavailable { get; } = new ProductAvailabilityStage(UnavailableValue);
        /// <summary> Determines if two <see cref="ProductAvailabilityStage"/> values are the same. </summary>
        public static bool operator ==(ProductAvailabilityStage left, ProductAvailabilityStage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProductAvailabilityStage"/> values are not the same. </summary>
        public static bool operator !=(ProductAvailabilityStage left, ProductAvailabilityStage right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ProductAvailabilityStage"/>. </summary>
        public static implicit operator ProductAvailabilityStage(string value) => new ProductAvailabilityStage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProductAvailabilityStage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProductAvailabilityStage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
