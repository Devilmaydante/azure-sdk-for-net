// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The network configuration for a Pool.
    /// </summary>
    public partial class NetworkConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the NetworkConfiguration class.
        /// </summary>
        public NetworkConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkConfiguration class.
        /// </summary>
        /// <param name="subnetId">The ARM resource identifier of the virtual
        /// network subnet which the Compute Nodes of the Pool will join. This
        /// is of the form
        /// /subscriptions/{subscription}/resourceGroups/{group}/providers/{provider}/virtualNetworks/{network}/subnets/{subnet}.</param>
        /// <param name="dynamicVNetAssignmentScope">The scope of dynamic vnet
        /// assignment.</param>
        /// <param name="endpointConfiguration">The configuration for endpoints
        /// on Compute Nodes in the Batch Pool.</param>
        /// <param name="publicIPs">The list of public IPs which the Batch
        /// service will use when provisioning Compute Nodes.</param>
        public NetworkConfiguration(string subnetId = default(string), DynamicVNetAssignmentScope? dynamicVNetAssignmentScope = default(DynamicVNetAssignmentScope?), PoolEndpointConfiguration endpointConfiguration = default(PoolEndpointConfiguration), IList<string> publicIPs = default(IList<string>))
        {
            SubnetId = subnetId;
            DynamicVNetAssignmentScope = dynamicVNetAssignmentScope;
            EndpointConfiguration = endpointConfiguration;
            PublicIPs = publicIPs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM resource identifier of the virtual network
        /// subnet which the Compute Nodes of the Pool will join. This is of
        /// the form
        /// /subscriptions/{subscription}/resourceGroups/{group}/providers/{provider}/virtualNetworks/{network}/subnets/{subnet}.
        /// </summary>
        /// <remarks>
        /// The virtual network must be in the same region and subscription as
        /// the Azure Batch Account. The specified subnet should have enough
        /// free IP addresses to accommodate the number of Compute Nodes in the
        /// Pool. If the subnet doesn't have enough free IP addresses, the Pool
        /// will partially allocate Nodes, and a resize error will occur. The
        /// 'MicrosoftAzureBatch' service principal must have the 'Classic
        /// Virtual Machine Contributor' Role-Based Access Control (RBAC) role
        /// for the specified VNet. The specified subnet must allow
        /// communication from the Azure Batch service to be able to schedule
        /// Tasks on the Nodes. This can be verified by checking if the
        /// specified VNet has any associated Network Security Groups (NSG). If
        /// communication to the Nodes in the specified subnet is denied by an
        /// NSG, then the Batch service will set the state of the Compute Nodes
        /// to unusable. For Pools created with virtualMachineConfiguration
        /// only ARM virtual networks ('Microsoft.Network/virtualNetworks') are
        /// supported, but for Pools created with cloudServiceConfiguration
        /// both ARM and classic virtual networks are supported. If the
        /// specified VNet has any associated Network Security Groups (NSG),
        /// then a few reserved system ports must be enabled for inbound
        /// communication. For Pools created with a virtual machine
        /// configuration, enable ports 29876 and 29877, as well as port 22 for
        /// Linux and port 3389 for Windows. For Pools created with a cloud
        /// service configuration, enable ports 10100, 20100, and 30100. Also
        /// enable outbound connections to Azure Storage on port 443. For more
        /// details see:
        /// https://docs.microsoft.com/en-us/azure/batch/batch-api-basics#virtual-network-vnet-and-firewall-configuration
        /// </remarks>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets or sets the scope of dynamic vnet assignment.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'none', 'job'
        /// </remarks>
        [JsonProperty(PropertyName = "dynamicVNetAssignmentScope")]
        public DynamicVNetAssignmentScope? DynamicVNetAssignmentScope { get; set; }

        /// <summary>
        /// Gets or sets the configuration for endpoints on Compute Nodes in
        /// the Batch Pool.
        /// </summary>
        /// <remarks>
        /// Pool endpoint configuration is only supported on Pools with the
        /// virtualMachineConfiguration property.
        /// </remarks>
        [JsonProperty(PropertyName = "endpointConfiguration")]
        public PoolEndpointConfiguration EndpointConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the list of public IPs which the Batch service will
        /// use when provisioning Compute Nodes.
        /// </summary>
        /// <remarks>
        /// The number of IPs specified here limits the maximum size of the
        /// Pool - 50 dedicated nodes or 20 low-priority nodes can be allocated
        /// for each public IP. For example, a pool needing 150 dedicated VMs
        /// would need at least 3 public IPs specified. Each element of this
        /// collection is of the form:
        /// /subscriptions/{subscription}/resourceGroups/{group}/providers/Microsoft.Network/publicIPAddresses/{ip}.
        /// </remarks>
        [JsonProperty(PropertyName = "publicIPs")]
        public IList<string> PublicIPs { get; set; }

    }
}
