// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Font weight. </summary>
    public readonly partial struct DocumentFontWeight : IEquatable<DocumentFontWeight>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentFontWeight"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentFontWeight(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NormalValue = "normal";
        private const string BoldValue = "bold";

        /// <summary> Characters are represented normally. </summary>
        public static DocumentFontWeight Normal { get; } = new DocumentFontWeight(NormalValue);
        /// <summary> Characters are represented with thicker strokes. </summary>
        public static DocumentFontWeight Bold { get; } = new DocumentFontWeight(BoldValue);
        /// <summary> Determines if two <see cref="DocumentFontWeight"/> values are the same. </summary>
        public static bool operator ==(DocumentFontWeight left, DocumentFontWeight right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentFontWeight"/> values are not the same. </summary>
        public static bool operator !=(DocumentFontWeight left, DocumentFontWeight right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DocumentFontWeight"/>. </summary>
        public static implicit operator DocumentFontWeight(string value) => new DocumentFontWeight(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentFontWeight other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentFontWeight other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
