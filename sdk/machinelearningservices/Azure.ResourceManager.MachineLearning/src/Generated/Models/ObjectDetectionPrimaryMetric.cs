// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Primary metrics for Image ObjectDetection task. </summary>
    public readonly partial struct ObjectDetectionPrimaryMetric : IEquatable<ObjectDetectionPrimaryMetric>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ObjectDetectionPrimaryMetric"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ObjectDetectionPrimaryMetric(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MeanAveragePrecisionValue = "MeanAveragePrecision";

        /// <summary>
        /// Mean Average Precision (MAP) is the average of AP (Average Precision).
        /// AP is calculated for each class and averaged to get the MAP.
        /// </summary>
        public static ObjectDetectionPrimaryMetric MeanAveragePrecision { get; } = new ObjectDetectionPrimaryMetric(MeanAveragePrecisionValue);
        /// <summary> Determines if two <see cref="ObjectDetectionPrimaryMetric"/> values are the same. </summary>
        public static bool operator ==(ObjectDetectionPrimaryMetric left, ObjectDetectionPrimaryMetric right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ObjectDetectionPrimaryMetric"/> values are not the same. </summary>
        public static bool operator !=(ObjectDetectionPrimaryMetric left, ObjectDetectionPrimaryMetric right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ObjectDetectionPrimaryMetric"/>. </summary>
        public static implicit operator ObjectDetectionPrimaryMetric(string value) => new ObjectDetectionPrimaryMetric(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ObjectDetectionPrimaryMetric other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ObjectDetectionPrimaryMetric other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
