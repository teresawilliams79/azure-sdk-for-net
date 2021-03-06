// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HubVirtualNetworkConnection Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HubVirtualNetworkConnection : Resource
    {
        /// <summary>
        /// Initializes a new instance of the HubVirtualNetworkConnection
        /// class.
        /// </summary>
        public HubVirtualNetworkConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HubVirtualNetworkConnection
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="remoteVirtualNetwork">Reference to the remote virtual
        /// network.</param>
        /// <param name="allowHubToRemoteVnetTransit">VirtualHub to RemoteVnet
        /// transit to enabled or not.</param>
        /// <param name="allowRemoteVnetToUseHubVnetGateways">Allow RemoteVnet
        /// to use Virtual Hub's gateways.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="etag">Gets a unique read-only string that changes
        /// whenever the resource is updated.</param>
        public HubVirtualNetworkConnection(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SubResource remoteVirtualNetwork = default(SubResource), bool? allowHubToRemoteVnetTransit = default(bool?), bool? allowRemoteVnetToUseHubVnetGateways = default(bool?), string provisioningState = default(string), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            RemoteVirtualNetwork = remoteVirtualNetwork;
            AllowHubToRemoteVnetTransit = allowHubToRemoteVnetTransit;
            AllowRemoteVnetToUseHubVnetGateways = allowRemoteVnetToUseHubVnetGateways;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference to the remote virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remoteVirtualNetwork")]
        public SubResource RemoteVirtualNetwork { get; set; }

        /// <summary>
        /// Gets or sets virtualHub to RemoteVnet transit to enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowHubToRemoteVnetTransit")]
        public bool? AllowHubToRemoteVnetTransit { get; set; }

        /// <summary>
        /// Gets or sets allow RemoteVnet to use Virtual Hub's gateways.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowRemoteVnetToUseHubVnetGateways")]
        public bool? AllowRemoteVnetToUseHubVnetGateways { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
