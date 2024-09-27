// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The type of the column in the report. </summary>
    public readonly partial struct QueryColumnType : IEquatable<QueryColumnType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QueryColumnType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryColumnType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TagKeyValue = "TagKey";
        private const string DimensionValue = "Dimension";

        /// <summary> The tag associated with the cost data. </summary>
        public static QueryColumnType TagKey { get; } = new QueryColumnType(TagKeyValue);
        /// <summary> The dimension of cost data. </summary>
        public static QueryColumnType Dimension { get; } = new QueryColumnType(DimensionValue);
        /// <summary> Determines if two <see cref="QueryColumnType"/> values are the same. </summary>
        public static bool operator ==(QueryColumnType left, QueryColumnType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryColumnType"/> values are not the same. </summary>
        public static bool operator !=(QueryColumnType left, QueryColumnType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="QueryColumnType"/>. </summary>
        public static implicit operator QueryColumnType(string value) => new QueryColumnType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryColumnType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryColumnType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
