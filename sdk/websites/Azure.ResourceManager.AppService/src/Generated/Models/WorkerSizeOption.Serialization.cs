// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class WorkerSizeOptionExtensions
    {
        public static string ToSerialString(this WorkerSizeOption value) => value switch
        {
            WorkerSizeOption.Small => "Small",
            WorkerSizeOption.Medium => "Medium",
            WorkerSizeOption.Large => "Large",
            WorkerSizeOption.D1 => "D1",
            WorkerSizeOption.D2 => "D2",
            WorkerSizeOption.D3 => "D3",
            WorkerSizeOption.SmallV3 => "SmallV3",
            WorkerSizeOption.MediumV3 => "MediumV3",
            WorkerSizeOption.LargeV3 => "LargeV3",
            WorkerSizeOption.NestedSmall => "NestedSmall",
            WorkerSizeOption.NestedSmallLinux => "NestedSmallLinux",
            WorkerSizeOption.Default => "Default",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WorkerSizeOption value.")
        };

        public static WorkerSizeOption ToWorkerSizeOption(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Small")) return WorkerSizeOption.Small;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Medium")) return WorkerSizeOption.Medium;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Large")) return WorkerSizeOption.Large;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "D1")) return WorkerSizeOption.D1;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "D2")) return WorkerSizeOption.D2;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "D3")) return WorkerSizeOption.D3;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SmallV3")) return WorkerSizeOption.SmallV3;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MediumV3")) return WorkerSizeOption.MediumV3;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "LargeV3")) return WorkerSizeOption.LargeV3;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NestedSmall")) return WorkerSizeOption.NestedSmall;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NestedSmallLinux")) return WorkerSizeOption.NestedSmallLinux;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Default")) return WorkerSizeOption.Default;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WorkerSizeOption value.");
        }
    }
}
