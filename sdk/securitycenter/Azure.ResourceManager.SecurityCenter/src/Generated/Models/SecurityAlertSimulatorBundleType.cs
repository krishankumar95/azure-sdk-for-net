// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Alert Simulator supported bundles. </summary>
    public readonly partial struct SecurityAlertSimulatorBundleType : IEquatable<SecurityAlertSimulatorBundleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityAlertSimulatorBundleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityAlertSimulatorBundleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AppServicesValue = "AppServices";
        private const string DnsValue = "DNS";
        private const string KeyVaultsValue = "KeyVaults";
        private const string KubernetesServiceValue = "KubernetesService";
        private const string ResourceManagerValue = "ResourceManager";
        private const string SqlServersValue = "SqlServers";
        private const string StorageAccountsValue = "StorageAccounts";
        private const string VirtualMachinesValue = "VirtualMachines";
        private const string CosmosDbsValue = "CosmosDbs";

        /// <summary> AppServices. </summary>
        public static SecurityAlertSimulatorBundleType AppServices { get; } = new SecurityAlertSimulatorBundleType(AppServicesValue);
        /// <summary> DNS. </summary>
        public static SecurityAlertSimulatorBundleType Dns { get; } = new SecurityAlertSimulatorBundleType(DnsValue);
        /// <summary> KeyVaults. </summary>
        public static SecurityAlertSimulatorBundleType KeyVaults { get; } = new SecurityAlertSimulatorBundleType(KeyVaultsValue);
        /// <summary> KubernetesService. </summary>
        public static SecurityAlertSimulatorBundleType KubernetesService { get; } = new SecurityAlertSimulatorBundleType(KubernetesServiceValue);
        /// <summary> ResourceManager. </summary>
        public static SecurityAlertSimulatorBundleType ResourceManager { get; } = new SecurityAlertSimulatorBundleType(ResourceManagerValue);
        /// <summary> SqlServers. </summary>
        public static SecurityAlertSimulatorBundleType SqlServers { get; } = new SecurityAlertSimulatorBundleType(SqlServersValue);
        /// <summary> StorageAccounts. </summary>
        public static SecurityAlertSimulatorBundleType StorageAccounts { get; } = new SecurityAlertSimulatorBundleType(StorageAccountsValue);
        /// <summary> VirtualMachines. </summary>
        public static SecurityAlertSimulatorBundleType VirtualMachines { get; } = new SecurityAlertSimulatorBundleType(VirtualMachinesValue);
        /// <summary> CosmosDbs. </summary>
        public static SecurityAlertSimulatorBundleType CosmosDbs { get; } = new SecurityAlertSimulatorBundleType(CosmosDbsValue);
        /// <summary> Determines if two <see cref="SecurityAlertSimulatorBundleType"/> values are the same. </summary>
        public static bool operator ==(SecurityAlertSimulatorBundleType left, SecurityAlertSimulatorBundleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityAlertSimulatorBundleType"/> values are not the same. </summary>
        public static bool operator !=(SecurityAlertSimulatorBundleType left, SecurityAlertSimulatorBundleType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecurityAlertSimulatorBundleType"/>. </summary>
        public static implicit operator SecurityAlertSimulatorBundleType(string value) => new SecurityAlertSimulatorBundleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityAlertSimulatorBundleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityAlertSimulatorBundleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
