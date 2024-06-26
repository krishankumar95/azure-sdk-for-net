// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    internal class ServiceFabricManagedApplicationTypeVersionOperationSource : IOperationSource<ServiceFabricManagedApplicationTypeVersionResource>
    {
        private readonly ArmClient _client;

        internal ServiceFabricManagedApplicationTypeVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceFabricManagedApplicationTypeVersionResource IOperationSource<ServiceFabricManagedApplicationTypeVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServiceFabricManagedApplicationTypeVersionData.DeserializeServiceFabricManagedApplicationTypeVersionData(document.RootElement);
            return new ServiceFabricManagedApplicationTypeVersionResource(_client, data);
        }

        async ValueTask<ServiceFabricManagedApplicationTypeVersionResource> IOperationSource<ServiceFabricManagedApplicationTypeVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServiceFabricManagedApplicationTypeVersionData.DeserializeServiceFabricManagedApplicationTypeVersionData(document.RootElement);
            return new ServiceFabricManagedApplicationTypeVersionResource(_client, data);
        }
    }
}
