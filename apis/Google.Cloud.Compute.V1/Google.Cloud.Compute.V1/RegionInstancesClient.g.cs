// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;

using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="RegionInstancesClient"/> instances.</summary>
    public sealed partial class RegionInstancesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionInstancesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionInstancesSettings"/>.</returns>
        public static RegionInstancesSettings GetDefault() => new RegionInstancesSettings();

        /// <summary>Constructs a new <see cref="RegionInstancesSettings"/> object with default settings.</summary>
        public RegionInstancesSettings()
        {
        }

        private RegionInstancesSettings(RegionInstancesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            BulkInsertSettings = existing.BulkInsertSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionInstancesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionInstancesClient.BulkInsert</c> and <c>RegionInstancesClient.BulkInsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkInsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionInstancesSettings"/> object.</returns>
        public RegionInstancesSettings Clone() => new RegionInstancesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionInstancesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class RegionInstancesClientBuilder : gaxgrpc::ClientBuilderBase<RegionInstancesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionInstancesSettings Settings { get; set; }

        partial void InterceptBuild(ref RegionInstancesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionInstancesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionInstancesClient Build()
        {
            RegionInstancesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionInstancesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionInstancesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionInstancesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionInstancesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RegionInstancesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionInstancesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RegionInstancesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RegionInstancesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionInstancesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>RegionInstances client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionInstances API.
    /// </remarks>
    public abstract partial class RegionInstancesClient
    {
        /// <summary>
        /// The default endpoint for the RegionInstances service, which is a host of "compute.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionInstances scopes.</summary>
        /// <remarks>
        /// The default RegionInstances scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="RegionInstancesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionInstancesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionInstancesClient"/>.</returns>
        public static stt::Task<RegionInstancesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionInstancesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionInstancesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionInstancesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionInstancesClient"/>.</returns>
        public static RegionInstancesClient Create() => new RegionInstancesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionInstancesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionInstancesSettings"/>.</param>
        /// <returns>The created <see cref="RegionInstancesClient"/>.</returns>
        internal static RegionInstancesClient Create(grpccore::CallInvoker callInvoker, RegionInstancesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionInstances.RegionInstancesClient grpcClient = new RegionInstances.RegionInstancesClient(callInvoker);
            return new RegionInstancesClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC RegionInstances client</summary>
        public virtual RegionInstances.RegionInstancesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple instances in a given region. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation BulkInsert(BulkInsertRegionInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple instances in a given region. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> BulkInsertAsync(BulkInsertRegionInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates multiple instances in a given region. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> BulkInsertAsync(BulkInsertRegionInstanceRequest request, st::CancellationToken cancellationToken) =>
            BulkInsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates multiple instances in a given region. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="bulkInsertInstanceResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation BulkInsert(string project, string region, BulkInsertInstanceResource bulkInsertInstanceResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsert(new BulkInsertRegionInstanceRequest
            {
                BulkInsertInstanceResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertInstanceResourceResource, nameof(bulkInsertInstanceResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates multiple instances in a given region. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="bulkInsertInstanceResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> BulkInsertAsync(string project, string region, BulkInsertInstanceResource bulkInsertInstanceResourceResource, gaxgrpc::CallSettings callSettings = null) =>
            BulkInsertAsync(new BulkInsertRegionInstanceRequest
            {
                BulkInsertInstanceResourceResource = gax::GaxPreconditions.CheckNotNull(bulkInsertInstanceResourceResource, nameof(bulkInsertInstanceResourceResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates multiple instances in a given region. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region for this request.
        /// </param>
        /// <param name="bulkInsertInstanceResourceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> BulkInsertAsync(string project, string region, BulkInsertInstanceResource bulkInsertInstanceResourceResource, st::CancellationToken cancellationToken) =>
            BulkInsertAsync(project, region, bulkInsertInstanceResourceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegionInstances client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionInstances API.
    /// </remarks>
    public sealed partial class RegionInstancesClientImpl : RegionInstancesClient
    {
        private readonly gaxgrpc::ApiCall<BulkInsertRegionInstanceRequest, Operation> _callBulkInsert;

        /// <summary>
        /// Constructs a client wrapper for the RegionInstances service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegionInstancesSettings"/> used within this client.</param>
        public RegionInstancesClientImpl(RegionInstances.RegionInstancesClient grpcClient, RegionInstancesSettings settings)
        {
            GrpcClient = grpcClient;
            RegionInstancesSettings effectiveSettings = settings ?? RegionInstancesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callBulkInsert = clientHelper.BuildApiCall<BulkInsertRegionInstanceRequest, Operation>(grpcClient.BulkInsertAsync, grpcClient.BulkInsert, effectiveSettings.BulkInsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callBulkInsert);
            Modify_BulkInsertApiCall(ref _callBulkInsert);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_BulkInsertApiCall(ref gaxgrpc::ApiCall<BulkInsertRegionInstanceRequest, Operation> call);

        partial void OnConstruction(RegionInstances.RegionInstancesClient grpcClient, RegionInstancesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionInstances client</summary>
        public override RegionInstances.RegionInstancesClient GrpcClient { get; }

        partial void Modify_BulkInsertRegionInstanceRequest(ref BulkInsertRegionInstanceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates multiple instances in a given region. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation BulkInsert(BulkInsertRegionInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertRegionInstanceRequest(ref request, ref callSettings);
            return _callBulkInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates multiple instances in a given region. Count specifies the number of instances to create.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> BulkInsertAsync(BulkInsertRegionInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkInsertRegionInstanceRequest(ref request, ref callSettings);
            return _callBulkInsert.Async(request, callSettings);
        }
    }
}
