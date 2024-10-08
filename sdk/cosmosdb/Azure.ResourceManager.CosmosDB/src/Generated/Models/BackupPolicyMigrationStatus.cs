// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Describes the status of migration between backup policy types. </summary>
    public readonly partial struct BackupPolicyMigrationStatus : IEquatable<BackupPolicyMigrationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupPolicyMigrationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupPolicyMigrationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string InProgressValue = "InProgress";
        private const string CompletedValue = "Completed";
        private const string FailedValue = "Failed";

        /// <summary> Invalid. </summary>
        public static BackupPolicyMigrationStatus Invalid { get; } = new BackupPolicyMigrationStatus(InvalidValue);
        /// <summary> InProgress. </summary>
        public static BackupPolicyMigrationStatus InProgress { get; } = new BackupPolicyMigrationStatus(InProgressValue);
        /// <summary> Completed. </summary>
        public static BackupPolicyMigrationStatus Completed { get; } = new BackupPolicyMigrationStatus(CompletedValue);
        /// <summary> Failed. </summary>
        public static BackupPolicyMigrationStatus Failed { get; } = new BackupPolicyMigrationStatus(FailedValue);
        /// <summary> Determines if two <see cref="BackupPolicyMigrationStatus"/> values are the same. </summary>
        public static bool operator ==(BackupPolicyMigrationStatus left, BackupPolicyMigrationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupPolicyMigrationStatus"/> values are not the same. </summary>
        public static bool operator !=(BackupPolicyMigrationStatus left, BackupPolicyMigrationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="BackupPolicyMigrationStatus"/>. </summary>
        public static implicit operator BackupPolicyMigrationStatus(string value) => new BackupPolicyMigrationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupPolicyMigrationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupPolicyMigrationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
