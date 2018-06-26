// Copyright 2018 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Google.Cloud.Compute.Prototype
{
    public partial class ComputeClient
    {
        partial void InitResources()
        {
            AcceleratorTypes = new Google.Cloud.Compute.Prototype.AcceleratorTypesClient(this);
            Addresses = new Google.Cloud.Compute.Prototype.AddressesClient(this);
            Autoscalers = new Google.Cloud.Compute.Prototype.AutoscalersClient(this);
            BackendBuckets = new Google.Cloud.Compute.Prototype.BackendBucketsClient(this);
            BackendServices = new Google.Cloud.Compute.Prototype.BackendServicesClient(this);
            DiskTypes = new Google.Cloud.Compute.Prototype.DiskTypesClient(this);
            Disks = new Google.Cloud.Compute.Prototype.DisksClient(this);
            Firewalls = new Google.Cloud.Compute.Prototype.FirewallsClient(this);
            ForwardingRules = new Google.Cloud.Compute.Prototype.ForwardingRulesClient(this);
            GlobalAddresses = new Google.Cloud.Compute.Prototype.GlobalAddressesClient(this);
            GlobalForwardingRules = new Google.Cloud.Compute.Prototype.GlobalForwardingRulesClient(this);
            GlobalOperations = new Google.Cloud.Compute.Prototype.GlobalOperationsClient(this);
            HealthChecks = new Google.Cloud.Compute.Prototype.HealthChecksClient(this);
            HttpHealthChecks = new Google.Cloud.Compute.Prototype.HttpHealthChecksClient(this);
            HttpsHealthChecks = new Google.Cloud.Compute.Prototype.HttpsHealthChecksClient(this);
            Images = new Google.Cloud.Compute.Prototype.ImagesClient(this);
            InstanceGroupManagers = new Google.Cloud.Compute.Prototype.InstanceGroupManagersClient(this);
            InstanceGroups = new Google.Cloud.Compute.Prototype.InstanceGroupsClient(this);
            InstanceTemplates = new Google.Cloud.Compute.Prototype.InstanceTemplatesClient(this);
            Instances = new Google.Cloud.Compute.Prototype.InstancesClient(this);
            InterconnectAttachments = new Google.Cloud.Compute.Prototype.InterconnectAttachmentsClient(this);
            InterconnectLocations = new Google.Cloud.Compute.Prototype.InterconnectLocationsClient(this);
            Interconnects = new Google.Cloud.Compute.Prototype.InterconnectsClient(this);
            LicenseCodes = new Google.Cloud.Compute.Prototype.LicenseCodesClient(this);
            Licenses = new Google.Cloud.Compute.Prototype.LicensesClient(this);
            MachineTypes = new Google.Cloud.Compute.Prototype.MachineTypesClient(this);
            Networks = new Google.Cloud.Compute.Prototype.NetworksClient(this);
            Projects = new Google.Cloud.Compute.Prototype.ProjectsClient(this);
            RegionAutoscalers = new Google.Cloud.Compute.Prototype.RegionAutoscalersClient(this);
            RegionBackendServices = new Google.Cloud.Compute.Prototype.RegionBackendServicesClient(this);
            RegionCommitments = new Google.Cloud.Compute.Prototype.RegionCommitmentsClient(this);
            RegionDiskTypes = new Google.Cloud.Compute.Prototype.RegionDiskTypesClient(this);
            RegionDisks = new Google.Cloud.Compute.Prototype.RegionDisksClient(this);
            RegionInstanceGroupManagers = new Google.Cloud.Compute.Prototype.RegionInstanceGroupManagersClient(this);
            RegionInstanceGroups = new Google.Cloud.Compute.Prototype.RegionInstanceGroupsClient(this);
            RegionOperations = new Google.Cloud.Compute.Prototype.RegionOperationsClient(this);
            Regions = new Google.Cloud.Compute.Prototype.RegionsClient(this);
            Routers = new Google.Cloud.Compute.Prototype.RoutersClient(this);
            Routes = new Google.Cloud.Compute.Prototype.RoutesClient(this);
            Snapshots = new Google.Cloud.Compute.Prototype.SnapshotsClient(this);
            SslCertificates = new Google.Cloud.Compute.Prototype.SslCertificatesClient(this);
            SslPolicies = new Google.Cloud.Compute.Prototype.SslPoliciesClient(this);
            Subnetworks = new Google.Cloud.Compute.Prototype.SubnetworksClient(this);
            TargetHttpProxies = new Google.Cloud.Compute.Prototype.TargetHttpProxiesClient(this);
            TargetHttpsProxies = new Google.Cloud.Compute.Prototype.TargetHttpsProxiesClient(this);
            TargetInstances = new Google.Cloud.Compute.Prototype.TargetInstancesClient(this);
            TargetPools = new Google.Cloud.Compute.Prototype.TargetPoolsClient(this);
            TargetSslProxies = new Google.Cloud.Compute.Prototype.TargetSslProxiesClient(this);
            TargetTcpProxies = new Google.Cloud.Compute.Prototype.TargetTcpProxiesClient(this);
            TargetVpnGateways = new Google.Cloud.Compute.Prototype.TargetVpnGatewaysClient(this);
            UrlMaps = new Google.Cloud.Compute.Prototype.UrlMapsClient(this);
            VpnTunnels = new Google.Cloud.Compute.Prototype.VpnTunnelsClient(this);
            ZoneOperations = new Google.Cloud.Compute.Prototype.ZoneOperationsClient(this);
            Zones = new Google.Cloud.Compute.Prototype.ZonesClient(this);

        }
        public Google.Cloud.Compute.Prototype.AcceleratorTypesClient AcceleratorTypes { get; private set; }
        public Google.Cloud.Compute.Prototype.AddressesClient Addresses { get; private set; }
        public Google.Cloud.Compute.Prototype.AutoscalersClient Autoscalers { get; private set; }
        public Google.Cloud.Compute.Prototype.BackendBucketsClient BackendBuckets { get; private set; }
        public Google.Cloud.Compute.Prototype.BackendServicesClient BackendServices { get; private set; }
        public Google.Cloud.Compute.Prototype.DiskTypesClient DiskTypes { get; private set; }
        public Google.Cloud.Compute.Prototype.DisksClient Disks { get; private set; }
        public Google.Cloud.Compute.Prototype.FirewallsClient Firewalls { get; private set; }
        public Google.Cloud.Compute.Prototype.ForwardingRulesClient ForwardingRules { get; private set; }
        public Google.Cloud.Compute.Prototype.GlobalAddressesClient GlobalAddresses { get; private set; }
        public Google.Cloud.Compute.Prototype.GlobalForwardingRulesClient GlobalForwardingRules { get; private set; }
        public Google.Cloud.Compute.Prototype.GlobalOperationsClient GlobalOperations { get; private set; }
        public Google.Cloud.Compute.Prototype.HealthChecksClient HealthChecks { get; private set; }
        public Google.Cloud.Compute.Prototype.HttpHealthChecksClient HttpHealthChecks { get; private set; }
        public Google.Cloud.Compute.Prototype.HttpsHealthChecksClient HttpsHealthChecks { get; private set; }
        public Google.Cloud.Compute.Prototype.ImagesClient Images { get; private set; }
        public Google.Cloud.Compute.Prototype.InstanceGroupManagersClient InstanceGroupManagers { get; private set; }
        public Google.Cloud.Compute.Prototype.InstanceGroupsClient InstanceGroups { get; private set; }
        public Google.Cloud.Compute.Prototype.InstanceTemplatesClient InstanceTemplates { get; private set; }
        public Google.Cloud.Compute.Prototype.InstancesClient Instances { get; private set; }
        public Google.Cloud.Compute.Prototype.InterconnectAttachmentsClient InterconnectAttachments { get; private set; }
        public Google.Cloud.Compute.Prototype.InterconnectLocationsClient InterconnectLocations { get; private set; }
        public Google.Cloud.Compute.Prototype.InterconnectsClient Interconnects { get; private set; }
        public Google.Cloud.Compute.Prototype.LicenseCodesClient LicenseCodes { get; private set; }
        public Google.Cloud.Compute.Prototype.LicensesClient Licenses { get; private set; }
        public Google.Cloud.Compute.Prototype.MachineTypesClient MachineTypes { get; private set; }
        public Google.Cloud.Compute.Prototype.NetworksClient Networks { get; private set; }
        public Google.Cloud.Compute.Prototype.ProjectsClient Projects { get; private set; }
        public Google.Cloud.Compute.Prototype.RegionAutoscalersClient RegionAutoscalers { get; private set; }
        public Google.Cloud.Compute.Prototype.RegionBackendServicesClient RegionBackendServices { get; private set; }
        public Google.Cloud.Compute.Prototype.RegionCommitmentsClient RegionCommitments { get; private set; }
        public Google.Cloud.Compute.Prototype.RegionDiskTypesClient RegionDiskTypes { get; private set; }
        public Google.Cloud.Compute.Prototype.RegionDisksClient RegionDisks { get; private set; }
        public Google.Cloud.Compute.Prototype.RegionInstanceGroupManagersClient RegionInstanceGroupManagers { get; private set; }
        public Google.Cloud.Compute.Prototype.RegionInstanceGroupsClient RegionInstanceGroups { get; private set; }
        public Google.Cloud.Compute.Prototype.RegionOperationsClient RegionOperations { get; private set; }
        public Google.Cloud.Compute.Prototype.RegionsClient Regions { get; private set; }
        public Google.Cloud.Compute.Prototype.RoutersClient Routers { get; private set; }
        public Google.Cloud.Compute.Prototype.RoutesClient Routes { get; private set; }
        public Google.Cloud.Compute.Prototype.SnapshotsClient Snapshots { get; private set; }
        public Google.Cloud.Compute.Prototype.SslCertificatesClient SslCertificates { get; private set; }
        public Google.Cloud.Compute.Prototype.SslPoliciesClient SslPolicies { get; private set; }
        public Google.Cloud.Compute.Prototype.SubnetworksClient Subnetworks { get; private set; }
        public Google.Cloud.Compute.Prototype.TargetHttpProxiesClient TargetHttpProxies { get; private set; }
        public Google.Cloud.Compute.Prototype.TargetHttpsProxiesClient TargetHttpsProxies { get; private set; }
        public Google.Cloud.Compute.Prototype.TargetInstancesClient TargetInstances { get; private set; }
        public Google.Cloud.Compute.Prototype.TargetPoolsClient TargetPools { get; private set; }
        public Google.Cloud.Compute.Prototype.TargetSslProxiesClient TargetSslProxies { get; private set; }
        public Google.Cloud.Compute.Prototype.TargetTcpProxiesClient TargetTcpProxies { get; private set; }
        public Google.Cloud.Compute.Prototype.TargetVpnGatewaysClient TargetVpnGateways { get; private set; }
        public Google.Cloud.Compute.Prototype.UrlMapsClient UrlMaps { get; private set; }
        public Google.Cloud.Compute.Prototype.VpnTunnelsClient VpnTunnels { get; private set; }
        public Google.Cloud.Compute.Prototype.ZoneOperationsClient ZoneOperations { get; private set; }
        public Google.Cloud.Compute.Prototype.ZonesClient Zones { get; private set; }
    }
}