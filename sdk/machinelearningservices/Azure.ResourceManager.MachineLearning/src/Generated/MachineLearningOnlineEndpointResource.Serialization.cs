// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningOnlineEndpointResource : IJsonModel<MachineLearningOnlineEndpointData>
    {
        void IJsonModel<MachineLearningOnlineEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningOnlineEndpointData>)Data).Write(writer, options);

        MachineLearningOnlineEndpointData IJsonModel<MachineLearningOnlineEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningOnlineEndpointData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningOnlineEndpointData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MachineLearningOnlineEndpointData IPersistableModel<MachineLearningOnlineEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningOnlineEndpointData>(data, options);

        string IPersistableModel<MachineLearningOnlineEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningOnlineEndpointData>)Data).GetFormatFromOptions(options);
    }
}
